using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.NetAssignment1_2
{
    public static class circleArea
    {
        public static int radius { get; set; }

        public static double calcArea(int radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}
