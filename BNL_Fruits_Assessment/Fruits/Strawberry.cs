using System.Drawing;

namespace BNL_Fruits_Assessment.Fruits
{
    public class Strawberry : Fruit
    {
        public Strawberry()
        {
            Weight = 0.05;
            Color = Color.Red;
            Price = 3.99M;
            DatePicked = DateTime.Now;
            HasSeeds = true;
            Image = @"/assets/images/strawberry.png";
        }
    }
}
