using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmus
{
    public static class SummenRechner
    {
        public static int SummeLoop(List<int> list) => list.Sum();

        public static int SummeRecursion(this List<int> list)
        {
            if (list.Count > 0)
            {
                return SummeRecursion(list.Take(list.Count - 1).ToList()) + list.Last();
            }

            return 0;
        }

        public static int SummeDrei(int a, int b, int c, int result)
        {
            if (a != 0)
            {
                a = a - 1;
                result = SummeDrei(a, b, c, result + 1);
            }

            else if (b != 0)
            {
                b = b - 1;
                result = SummeDrei(a, b, c, result + 1);
            }

            else if (c != 0)
            {
                c = c - 1;
                result = SummeDrei(a, b, c, result + 1);
            }

            return result;
        }
    }
}
