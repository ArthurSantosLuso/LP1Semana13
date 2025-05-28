using System;
using System.Collections.Generic;
using System.Net;

namespace MultipleStuff
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<double> list = new List<double>() { 1, 2, 3, 4, 5, 6 };

            SuperList sprList = new SuperList();

            sprList.AddRange(list);

            // Versão 1

            double min = default;
            double max = default;

            sprList.GetMinMax1(out min, out max);

            Console.WriteLine($"Versão 1: Min: {min} Max: {max}");

            // Versão 2

            MinMaxStruct minMax = sprList.GetMinMax2();

            Console.WriteLine($"Versão 2: Min: {minMax.Min} Max: {minMax.Max}");

            // Versão 3

            Tuple<double, double> tupleMinMax = sprList.GetMinMax3();

            Console.WriteLine($"Versão 3: Min: {tupleMinMax.Item1} Max: {tupleMinMax.Item2}");

            // Versão 4

            (double Min, double Max) tupleValueMinMax = sprList.GetMinMax4();

            Console.WriteLine($"Versão 4: Min: {tupleValueMinMax.Min} Max: {tupleValueMinMax.Max}");
        }
    }
}
