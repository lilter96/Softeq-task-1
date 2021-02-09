using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using rabota.Models;

namespace rabota
{
    class Program
    {
        static void Main(string[] args)
        {
            int testsCount = 0;
            List<decimal> numbers = new List<decimal>();
            InputData.Get(ref testsCount, ref numbers);

            foreach (var item in numbers)
            {
                Console.WriteLine("{0:F3}", Polynomial.GetPolynomialValue(item));
            }
        }
    }
}
