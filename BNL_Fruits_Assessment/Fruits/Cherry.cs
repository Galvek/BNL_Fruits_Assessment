using System.Drawing;

namespace BNL_Fruits_Assessment.Fruits
{
    public class Cherry : Fruit
    {
        public Cherry()
        {
            Weight = 0.16;
            Color = Color.Red;
            Price = 0.05M;
            DatePicked = new DateTime(2023, 07, 01);
            HasSeeds = true;
            Image = @"/assets/images/cherry.png";
        }
    }
}
