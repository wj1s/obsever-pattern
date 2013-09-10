using ObserverPattern;
using Xunit;

namespace ObserverPatternTest
{
    public class WeatherDataFact
    {
        private readonly SeedingMachine seedingMachine = new SeedingMachine();
        private readonly ReapingMachine reapingMachine = new ReapingMachine();
        private readonly WateringMachine wateringMachine = new WateringMachine();
        private readonly WeatherData weatherData;

        public WeatherDataFact()
        {
            weatherData = new WeatherData(seedingMachine, reapingMachine, wateringMachine);
        }

        [Fact]
        public void seeding_machine_should_start_if_temperature_over_5_degree()
        {
            weatherData.MeasurementsChanged(10, 0, 0);
            Assert.True(seedingMachine.Status);
        }
        
        [Fact]
        public void reaping_machine_should_start_if_temperature_over_5_degree_and_humidity_over_65()
        {
            weatherData.MeasurementsChanged(10, 70, 0);
            Assert.True(reapingMachine.Status);
        }

        [Fact]
        public void water_machine_should_start_if_temperature_over_10_degree_and_humidity_less_than_55_and_wind_power_less_than_4()
        {
            weatherData.MeasurementsChanged(12, 50, 2);
            Assert.True(wateringMachine.Status);
        }
    }
}