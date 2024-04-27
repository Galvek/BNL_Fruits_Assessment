using BNL_Fruits_Assessment.Fruits;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace BNL_Fruits_Assessment.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<IndexModel> _logger;

        private List<Fruit> Fruits { get; set; } = [];
        public List<Fruit> FilteredFruits { get; set; } = [];

        [BindProperty]
        public DateOnly FilterDate { get; set; }

        public IndexModel(IMemoryCache memoryCache, ILogger<IndexModel> logger)
        {
            _memoryCache = memoryCache;
            _logger = logger;
        }

        public void OnGet()
        {
            FilterDate = new DateOnly(2023, 01, 01);
            Fruits = new List<Fruit>()
            {
                //ripe banana
                new Banana()
                {
                    DatePicked = new DateTime(2023, 05, 01)
                },
                //freshly picked banana
                new Banana()
                {
                    Color = Color.LightGreen,
                    Image = @"/assets/images/banana_green.png"
                },
                //red apple
                new Apple(),
                //green apple
                new Apple()
                {
                    Color = Color.Green,
                    Image = @"/assets/images/apple_green.png"
                },
                //red cherry - with seeds
                new Cherry(),
                //red cherry - no seeds
                new Cherry()
                {
                    HasSeeds = false
                },
                //black cherry
                new Cherry()
                {
                    Color = Color.Purple,
                    Image = @"/assets/images/cherry_black.png"
                },
                new Coconut(),
                new Strawberry(),
                new Kiwi()
            };

            FilteredFruits.AddRange(Fruits);

            if (!_memoryCache.TryGetValue("fruits", out List<Fruit>? fruits))
            {
                fruits = Fruits;

                _memoryCache.Set("fruits", fruits);
            }
        }

        public void OnPost()
        {
            List<Fruit>? fruits = _memoryCache.Get<List<Fruit>>("fruits");

            if (fruits != null)
                FilteredFruits = fruits.Where(f => f.DatePicked > FilterDate.ToDateTime(new TimeOnly())).ToList();
        }

        public string ToHex(Color c)
        {
            return $"#{c.R:X2}{c.G:X2}{c.B:X2}";
        }
    }
}