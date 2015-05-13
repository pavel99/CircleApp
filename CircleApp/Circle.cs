using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {


        public double GetDiameter(double radious)
        {
            return 2*radious;
        }

        public double GetPerimeter(double radious)
        {
            return 2*Math.PI*radious;
        }

        public double GetArea(double radious)
        {
            return Math.PI*radious*radious;
        }
    }
}
