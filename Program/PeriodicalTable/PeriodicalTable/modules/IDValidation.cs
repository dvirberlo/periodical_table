using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicalTable
{
    class IDValidation
    {
        public static bool IsValidID(int id)
        {
            return GetCheckID(id / 10) == id % 10;
        }
        public static int GetCheckID(int id)
        {
            return (10 - (IDalg_R(id) % 10)) % 10;
        }
        public static int IDalg_R(int id, int weight = 1)
        {
            int alg = (weight + 1) * (id % 10);
            alg = (alg % 10) + (alg / 10);
            if (id < 10) return alg;
            return alg + IDalg_R(id / 10, (weight + 1) % 2);
        }
    }
}
