namespace UnitConversionAPPLICATION.Interfaces
{
    public interface IConversionStrategy
    {
        string Category { get; }

        decimal Convert(
            string fromUnit,
            string toUnit,
            decimal value);
    }
}
