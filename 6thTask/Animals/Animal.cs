using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        protected double Satiety { get; set; }

        public virtual void Feed(FoodType foodType, int count)
        {
            Satiety += count;
            Console.WriteLine("Om-nom-nom");
        }
    }
}
