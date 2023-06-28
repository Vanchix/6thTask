using _6thTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    internal class Triangle : Figure
    {
        public double Side { get; set; }
        public double Height { get; set; }
        public override double AreaCalculating()

        {
            return 0.5 * Side * Height;
        }
    }
}