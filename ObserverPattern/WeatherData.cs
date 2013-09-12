using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData
    {
        private List<IObsever> obsevers = new List<IObsever>();

        public WeatherData(SeedingMachine seedingMachine, ReapingMachine reapingMachine, WateringMachine wateringMachine)
        {
            obsevers.Add(new SeedingMachineObsever(seedingMachine));
            obsevers.Add(new ReapingMachineObserver(reapingMachine));
            obsevers.Add(new WateringMachineObserver(wateringMachine));
        }

        public void MeasurementsChanged(int temp, int humidity, int windPower)
        {
            obsevers.ForEach(o=>o.Update(temp,humidity,windPower));
        }
    }
}