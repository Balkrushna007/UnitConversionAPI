using UnitConversionAPPLICATION.Interfaces;

namespace UnitConversionINFRASTRUCTURE.Services
{
    public class TemperatureConversionStrategy
    : IConversionStrategy
    {
        public string Category => "Temperature";

        public decimal Convert(
            string fromUnit,
            string toUnit,
            decimal value)
        {
            double celsius = fromUnit switch
            {
                "Celsius" => (double)value,
                "Fahrenheit" => ((double)value - 32) * 5 / 9,
                "Kelvin" => (double)value - 273.15,
                _ => throw new ArgumentException()
            };

            return toUnit switch
            {
                "Celsius" => (decimal)celsius,
                "Fahrenheit" => (decimal)(celsius * 9 / 5 + 32),
                "Kelvin" => (decimal)(celsius + 273.15),
                _ => throw new ArgumentException()
            };
        }
    }
}
