using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Pig : Animal
    {
            public int Age { get; set; }

            public void Feed(int count)
            {
                Satiety += count;
                Console.WriteLine("Om-nom-nom");
            }
    }
}
