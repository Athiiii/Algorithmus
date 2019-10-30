using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmus
{
    public static class Greedy
    {
        public static List<double> GreeyLoop(this List<double> list, double goal)
        {
            var greedyList = new List<double>();

            while (list.Count > 0 && goal != greedyList.Sum())
            {
                var highestNumber = list.Max();

                if (greedyList.Sum() + highestNumber <= goal)
                {
                    greedyList.Add(highestNumber);
                    list.Remove(highestNumber);
                }
                else
                {
                    greedyList.Remove(greedyList.Last());
                    greedyList.Add(highestNumber);
                    list.Remove(highestNumber);
                }
            }

            return greedyList;
        }
    }
}
