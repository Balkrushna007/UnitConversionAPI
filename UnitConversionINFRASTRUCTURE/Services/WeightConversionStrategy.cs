using UnitConversionAPPLICATION.Interfaces;

namespace UnitConversionINFRASTRUCTURE.Services
{
    public class WeightConversionStrategy : IConversionStrategy
    {
        public string Category => "Weight";

        private readonly Dictionary<string, decimal> _units =
            new()
            {
            {"Kilogram",1m},
            {"Gram",0.001m},
            {"Pound",0.453592m}
            };

        public decimal Convert(
            string fromUnit,
            string toUnit,
            decimal value)
        {
            var kg = value * _units[fromUnit];

            return kg / _units[toUnit];
        }
    }
}
