using System.Drawing;

namespace BNL_Fruits_Assessment.Fruits
{
    public abstract class Fruit
    {
        /// <summary>
        /// Weight in LBs (pounds)
        /// </summary>
        public virtual double Weight { get; set; }
        public virtual Color Color { get; set; }
        public virtual decimal Price { get; set; }
        public virtual DateTime DatePicked { get; set; }
        public virtual bool HasSeeds { get; set; }
        public virtual bool IsEdible { get; set; }
        public virtual string? Image { get; set; }

        public virtual void MakeEdible()
        {
            IsEdible = true;
        }
    }
}
