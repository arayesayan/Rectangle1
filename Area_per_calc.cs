using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Area_per_calc
    {
        float ar, p;
        public float calc_ar(float l, float w)
        {
            ar = l * w;            
            return ar;
        }
        public float calc_p(float l, float w)
        {
            p = 2 * (l + w);
            return p;
        }
    }
}
