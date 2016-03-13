using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Draw5
    {
        // gic gcox funtion
        static void drawline(float l, string beg, string end, string mid)
        {
            Console.Write(beg);
            for (int i = 1; i < l - 1; ++i)
                Console.Write(mid);
            Console.WriteLine(end);
        }
        // ughankyun gcox function
        public void drawbox(float w, float l)
        {
            drawline(w, "*", " *", " *");
            for (int i = 1; i < l - 1; ++i)
                drawline(w, "*", " *", "  ");
            drawline(w, "*", " *", " *");
        }
    }
}
