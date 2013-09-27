using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData
    {
        private List<IObserver> observers = new List<IObserver>();

        public WeatherData(SeedingMachine seedingMachine, ReapingMachine reapingMachine, WateringMachine wateringMachine)
        {
            observers.Add(new SeedingMachineObserver(seedingMachine));
            observers.Add(new ReapingMachineObserver(reapingMachine));
            observers.Add(new WateringMachineObserver(wateringMachine));
        }

        public void MeasurementsChanged(int temp, int humidity, int windPower)
        {
            observers.ForEach(o=>o.Update(temp,humidity,windPower));
        }
    }
}