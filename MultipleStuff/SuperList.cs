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
        public void GetMinMax1(List<double> list, out double min, out double max)
        {
            min = list.Min();
            max = list.Max();
        }

        public static MinMaxStruct GetMinMax2(List<double> list)
        {
            return new MinMaxStruct(list.Min(), list.Max());
        }

        public static Tuple<double, double> GetMinMax3(List<double> list)
        {
            return Tuple.Create(list.Min(), list.Max());
        }

        public static (double min, double max) GetMinMax4(List<double> list)
        {
            return (list.Min(), list.Max());
        }

    }

    struct MinMaxStruct
    {
        public double Max { get; }
        public double Min { get; }

        public MinMaxStruct(double min, double max)
        {
            Min = min;
            Max = max;
        }
    }
}
