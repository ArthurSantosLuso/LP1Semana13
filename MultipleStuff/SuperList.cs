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
    }
}
