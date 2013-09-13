namespace ObserverPattern
{
    public class WeatherData
    {
        private readonly SeedingMachine seedingMachine;
        private readonly ReapingMachine reapingMachine;
        private readonly WateringMachine wateringMachine;

        public WeatherData(SeedingMachine seedingMachine, ReapingMachine reapingMachine, WateringMachine wateringMachine)
        {
            this.seedingMachine = seedingMachine;
            this.reapingMachine = reapingMachine;
            this.wateringMachine = wateringMachine;
        }

        public void MeasurementsChanged(int temp, int humidity, int windPower)
        {
            new SeedingMachineObsever(seedingMachine).SeedingMachineUpdate(temp);
            new ReapingMachineObserver(reapingMachine).ReapingMachineUpdate(temp, humidity);
            new WateringMachineObserver(wateringMachine).WateringMachineUpdate(temp, humidity, windPower);
        }
    }
}
