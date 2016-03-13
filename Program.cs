using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            float l, w, ar, p;
            Console.WriteLine("Please enter length of rectangle in cm: ");
                l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter width of rectangle in cm: ");
                w = Convert.ToInt32(Console.ReadLine());
            //hashvark
            Area_per_calc calc1 = new Area_per_calc();
            Console.WriteLine(calc1.calc_ar(l,w) + "sq cm" + " is area");
            Console.WriteLine(calc1.calc_p(l, w) + "cm" + " is perimeter");
            //nkarum enq ughankyune
            Draw5 draw = new Draw5();
            draw.drawbox(l, w);
            //verj
            Console.ReadKey();
        }        
    }
}
