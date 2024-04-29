using System.Drawing;

namespace BNL_Fruits_Assessment.Fruits
{
    public class Kiwi : Fruit
    {
        public Kiwi()
        {
            Weight = 2.4;
            Color = Color.Green;
            Price = 0.99M;
            DatePicked = DateTime.Now;
            HasSeeds = true;
            Image = @"/assets/images/kiwi.png";
        }
    }
}
