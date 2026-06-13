using UnitConversionAPPLICATION.Interfaces;

namespace UnitConversionINFRASTRUCTURE.Services
{
    public class LengthConversionStrategy : IConversionStrategy
    {
        public string Category => "Length";

        private readonly Dictionary<string, decimal> _units =
            new()
            {
            {"Meter",1m},
            {"Kilometer",1000m},
            {"Foot",0.3048m},
            {"Mile",1609.34m}
            };

        public decimal Convert(
            string fromUnit,
            string toUnit,
            decimal value)
        {
            var meters = value * _units[fromUnit];

            return meters / _units[toUnit];
        }
    }
}
