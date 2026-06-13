namespace UnitConversionAPPLICATION.DTOs
{
    public class ConversionRequest
    {
        public string Category { get; set; } = string.Empty;

        public string FromUnit { get; set; } = string.Empty;

        public string ToUnit { get; set; } = string.Empty;

        public decimal Value { get; set; }
    }
}
