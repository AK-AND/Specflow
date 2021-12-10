using NUnit.Framework;
using Poc.Surface.IntegrationTest.WebApi.Controllers;

namespace Poc.Surface.IntegrationTest.WebApi.Test.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        WeatherForecastController? weatherForecast;

        [Given(@"DB has latest weather reports")]
        public void GivenDBHasLatestWeatherReports()
        { 
            weatherForecast = new WeatherForecastController();
        }

        [When(@"I hit the get endpoint")]
        public void WhenIHitTheGetEndpoint()
        {
        }

        [Then(@"the rsponse should be return latest weather report")]
        public void ThenTheRsponseShouldBeReturnLatestWeatherReport()
        {
            var response = weatherForecast.Get();
            Assert.Greater(response.Count(), 0);
        }
    }
}