using System;
using Xunit;
using  WeatherAPI.Controllers;

namespace WeatherAPI.Test
{
    public class UnitTest1
    {
        readonly WeatherForecastController weatherForecast = new WeatherForecastController();

        [Fact]
        public void GetWeatherById()
        {
            var actuaValue = weatherForecast.GetSpecificWheather(1);
            Assert.Equal("Cool",actuaValue.Value);
        }
    }
}
