using System.Drawing;

namespace BNL_Fruits_Assessment.Fruits
{
    public class Banana : Fruit
    {
        public Banana()
        {
            Weight = 0.33;
            Color = Color.Yellow;
            Price = 1.25M;
            DatePicked = new DateTime(2023, 07, 01);
            HasSeeds = false;
            Image = @"/assets/images/banana.png";
        }
    }
}
