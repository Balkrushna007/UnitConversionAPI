using UnitConversionAPPLICATION.Interfaces;

namespace UnitConversionINFRASTRUCTURE.Services
{
    public class UnitConversionService
    : IUnitConversionService
    {
        private readonly IEnumerable<IConversionStrategy> _strategies;

        public UnitConversionService(
            IEnumerable<IConversionStrategy> strategies)
        {
            _strategies = strategies;
        }

        public decimal Convert(
            string category,
            string fromUnit,
            string toUnit,
            decimal value)
        {
            var strategy = _strategies.FirstOrDefault(
                x => x.Category.Equals(
                    category,
                    StringComparison.OrdinalIgnoreCase));

            if (strategy == null)
                throw new ArgumentException("Category not found");

            return strategy.Convert(
                fromUnit,
                toUnit,
                value);
        }
    }
}
