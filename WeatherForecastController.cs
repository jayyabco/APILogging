using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController()
        {
        }

        [HttpGet("GetWeatherForecast")]
        public IActionResult GetData()
        {
            Exception ex1 = new Exception("Test exception");
            /*try
            {
                throw new InvalidOperationException("Simulated exception for testing.");
            }
            catch (Exception ex)
            {
                // expose stack trace
                return Ok(ex.StackTrace);
            } */
            return Ok(ex1.StackTrace);
        }

        [HttpGet("GetWeatherForecast2")]
        public IActionResult GetData2()
        {
            try
            {
                throw new Exception("Normal exception.");
            }
            catch (Exception ex)
            {
                // expose stack trace
                return Ok(ex);
            }
        }

        [HttpGet("GetWeatherForecast3")]
        public IActionResult GetData3()
        {
            try
            {
                throw new ArgumentNullException("NULL exception for testing.");
            }
            catch (Exception ex)
            {
                // expose stack trace
                return BadRequest(ex.StackTrace);
            }
        }
    }
}