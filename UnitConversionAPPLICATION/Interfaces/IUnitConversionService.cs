namespace UnitConversionAPPLICATION.Interfaces
{
    public interface IUnitConversionService
    {
        decimal Convert(string category,string fromUnit,string toUnit,decimal value);
    }
}
