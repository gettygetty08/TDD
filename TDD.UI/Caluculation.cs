using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.UI
{
    public static class Caluculation
    {
        public static int Ave(List<int> list)
        {
            var sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }

            return sum/list.Count;
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }


    }
}
