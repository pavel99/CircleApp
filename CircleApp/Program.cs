using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("please enter the radius of the circle");
            double radius = Convert.ToDouble(Console.ReadLine());

            Circle myCircle=new Circle();

            Console.WriteLine("The Diameter is :"+myCircle.GetDiameter(radius));
            Console.WriteLine("The Perimeter is :"+myCircle.GetPerimeter(radius));
            Console.WriteLine("The Area of Circle is :"+myCircle.GetArea(radius));
        }
    }
}
