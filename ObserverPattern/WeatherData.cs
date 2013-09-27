namespace ObserverPattern
{
    public class WeatherData
    {
        private readonly ReapingMachine reapingMachine;
        private readonly SeedingMachine seedingMachine;
        private readonly WateringMachine wateringMachine;

        public WeatherData(SeedingMachine seedingMachine, ReapingMachine reapingMachine, WateringMachine wateringMachine)
        {
            this.seedingMachine = seedingMachine;
            this.reapingMachine = reapingMachine;
            this.wateringMachine = wateringMachine;
        }

        public void MeasurementsChanged(int temp, int humidity, int windPower)
        {
            new SeedingMachineObserver(seedingMachine).Update(temp, humidity, windPower);
            new ReapingMachineObserver(reapingMachine).Update(temp, humidity, windPower);
            new WateringMachineObserver(wateringMachine).Update(temp, humidity, windPower);
        }
    }
}