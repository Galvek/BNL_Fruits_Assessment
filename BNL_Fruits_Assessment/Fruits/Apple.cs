using System.Drawing;

namespace BNL_Fruits_Assessment.Fruits
{
    public class Apple : Fruit
    {
        public Apple()
        {
            Weight = 0.65;
            Color = Color.Red;
            Price = 1.25M;
            DatePicked = new DateTime(2023, 10, 01);
            HasSeeds = true;
            Image = @"/assets/images/apple.png";
        }
    }
}
