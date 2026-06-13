using FluentAssertions;
using UnitConversionINFRASTRUCTURE.Services;
using Xunit;

namespace UnitConversionUNITTESTCASE
{
    public class LengthConversionStrategyTests
    {
        [Fact]
        public void Meter_To_Foot_Should_Return_Correct_Value()
        {
            // Arrange
            var strategy = new LengthConversionStrategy();

            // Act
            var result = strategy.Convert(
                "Meter",
                "Foot",
                10);

            // Assert
            result.Should().BeApproximately(
                32.8084m,
                0.0001m);
        }
    }
}
