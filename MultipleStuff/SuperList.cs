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
        public void GetMinMax1(out double min, out double max)
        {
            min = this.Min();
            max = this.Max();
        }

        public MinMaxStruct GetMinMax2()
        {
            return new MinMaxStruct(this.Min(), this.Max());
        }

        public Tuple<double, double> GetMinMax3()
        {
            return Tuple.Create(this.Min(), this.Max());
        }

        public (double Min, double Max) GetMinMax4()
        {
            return (this.Min(), this.Max());
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
