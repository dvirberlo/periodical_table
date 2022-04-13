using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicalTable.modules
{
    class Convertings
    {
        public static int IntParse(String str)
        {
            int result = 0;
            int.TryParse(str, out result);
            return result;
        }
        public static double DoubleParse(String str)
        {
            double result = 0;
            double.TryParse(str, out result);
            return result;
        }
    }
}
