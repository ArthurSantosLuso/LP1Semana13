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
        public List<double> Lista { get; }

        public SuperList(List<double> list)
        {
            Lista = list;
        }

        public void GetMinMax1(out double min, out double max)
        {
            min = Lista.Min();
            max = Lista.Max();
        }

        public MinMaxStruct GetMinMax2()
        {
            return new MinMaxStruct(Lista.Min(), Lista.Max());
        }

        public Tuple<double, double> GetMinMax3()
        {
            return Tuple.Create(Lista.Min(), Lista.Max());
        }

        public (double min, double max) GetMinMax4()
        {
            return (Lista.Min(), Lista.Max());
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
