using Newtonsoft.Json;
using rabota.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace rabota
{
    /// <summary>
    /// This class presents Cheetah's program class.
    /// </summary>
    static class Polynomial
    {
        static private readonly Coefficients _coefficients;
        static Polynomial()
        {
            _coefficients = JsonConvert.DeserializeObject<Coefficients>(JsonCoefficients.GetJsonCoefficients());
        }
        /// <summary>
        /// This method returns value of polynomial for a given value of x.
        /// </summary>
        /// <param name="x">Value of x</param>
        /// <returns>Value of polynomial</returns>
        static public decimal GetPolynomialValue(decimal x)
        {
            return x * x * x * x * _coefficients.A + x * x * x * _coefficients.B + x * x * _coefficients.C +
                    x * _coefficients.D + _coefficients.E;
        }
    }
}
