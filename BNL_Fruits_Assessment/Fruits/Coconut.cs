using System.Drawing;

namespace BNL_Fruits_Assessment.Fruits
{
    public class Coconut : Fruit
    {
        public Coconut()
        {
            Weight = 2.00;
            Color = Color.Tan;
            Price = 2.99M;
            DatePicked = new DateTime(2024, 07, 15);
            HasSeeds = false;
            Image = @"/assets/images/coconut.png";
        }
    }
}
