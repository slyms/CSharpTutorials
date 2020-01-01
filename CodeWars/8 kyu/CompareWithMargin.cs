using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._8_kyu
{
    public class CompareWithMargin
    {
        public static int CloseCompare(double a, double b, double margin = 0)
        {
            double c;
            if (a - b > 0)
            {
                c = a - b;
            }
            else
            {
                c = (a - b) * -1;
            }

            if (margin <= 0)
            {
                if (a < b)
                    return -1;
                else if (a > b)
                    return 1;
                else //(a == b)
                    return 0;
            }
            else
            {
                if ((a < b) && (c <= margin))
                {
                    return 0;
                }
                else if ((a < b) && (c > margin))
                {
                    return -1;
                }
                else if ((a > b) && (c <= margin))
                {
                    return 0;
                }
                else if ((a > b) && (c > margin))
                    return 1;
                else
                    return 0;
            }
        }
    }
}
