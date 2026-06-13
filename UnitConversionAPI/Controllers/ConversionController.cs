using Microsoft.AspNetCore.Mvc;
using UnitConversionAPPLICATION.DTOs;
using UnitConversionAPPLICATION.Interfaces;

namespace UnitConversionAPI.Controllers
{
    [Route("api/conversions")]
    [ApiController]
    public class ConversionController : ControllerBase
    {
        private readonly IUnitConversionService _service;

        public ConversionController(
            IUnitConversionService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Convert(
        ConversionRequest request)
        {
            var result = _service.Convert(
                request.Category,
                request.FromUnit,
                request.ToUnit,
                request.Value);

            return Ok(new
            {
                OriginalValue = request.Value,
                request.FromUnit,
                request.ToUnit,
                ConvertedValue = Math.Round(result, 2)
            });
        }
    }
}
