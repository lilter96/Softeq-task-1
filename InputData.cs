using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace rabota
{
    /// <summary>
    /// This class provides all input data
    /// </summary>
    static class InputData
    {
        static public NumberFormatInfo FormatInfo { get; private set; } = new NumberFormatInfo();
        /// <summary>
        /// This method provide access to input data
        /// </summary>
        /// <param name="testsCount">Count of tests</param>
        /// <param name="numbers">Numbers for evaluation</param>
        static public void Get(ref int testsCount, ref List<decimal> numbers)
        {
            FormatInfo.NumberDecimalSeparator = ".";

            bool result = int.TryParse(Console.ReadLine().Trim(), out testsCount);
            if (!result)
            {
                Console.WriteLine("Check input");
                return;
            }

            while (testsCount-- > 0)
            {
                decimal x;
                try
                {
                    x = decimal.Parse(Console.ReadLine().Trim(), FormatInfo);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bad input!");
                    continue;
                }

                numbers.Add(x);
            }
        }
    }
}
