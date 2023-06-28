using _6thTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArea
{
    internal class Square : Figure
    {
        public double Side { get; set; }
        public override double AreaCalculating()

        {
            return Math.Pow(Side, 2);
        }
    }
}
