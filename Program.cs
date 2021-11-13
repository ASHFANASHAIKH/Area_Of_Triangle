using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Of_Triangle
{
    class Program
    {
       public static void Main(string[] args)
        {
            //area= base * height / 2
            Console.WriteLine("Enter the base of triangle:");
            double trianglebase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of triangle:");
            double triangleheight = Convert.ToDouble(Console.ReadLine());
            double AreaOfTriangle = (trianglebase* triangleheight)/2;
           Console.WriteLine(" Area Of Triangle is: " + AreaOfTriangle);

        }

    }
}
