using System.IO;

namespace rabota
{
    /// <summary>
    /// This static class takes from coefficients.json coeffiecients then outputs coefficients as string value.
    /// </summary>
    static class JsonCoefficients
    {
        static private readonly string path;
        /// <summary>
        /// Puts values of coefficients
        /// </summary>
        static JsonCoefficients()
        {
            path = Path.Combine("../../../", "data", "coefficients.json");
        }
        /// <summary>
        /// This method outputs the values of coefficients
        /// </summary>
        /// <returns>Coefficients as string value</returns>
        static public string GetJsonCoefficients()
        {
            if (!File.Exists(path))
            {
                return string.Empty;
            }
            return File.ReadAllText(path);
        }
    }
}
