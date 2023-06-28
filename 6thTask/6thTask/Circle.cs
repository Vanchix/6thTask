using _6thTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    internal class Circle : Figure
    {
        public double CircleRadius { get; set; }

        private double pi = 3.14;
        public override double AreaCalculating()

        {
            return pi * (Math.Pow(CircleRadius, 2));
        }
    }
}
