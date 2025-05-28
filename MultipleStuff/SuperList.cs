using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MultipleStuff
{
    class SuperList : List<Double>
    {
        private void GetMinMax1(List<double> list, out double min, out double max)
        {
            min = list.Min();
            max = list.Max();
        }

        private static Tuple<double, double> GetMinMax3(List<double> list)
        {
            return Tuple.Create(list.Min(), list.Max());
        }
    }
}
