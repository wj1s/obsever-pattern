using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData
    {
        private List<IObserver> observers = new List<IObserver>();

        public WeatherData(SeedingMachine seedingMachine, ReapingMachine reapingMachine, WateringMachine wateringMachine)
        {
            Subscribe(new SeedingMachineObserver(seedingMachine));
            Subscribe(new ReapingMachineObserver(reapingMachine));
            Subscribe(new WateringMachineObserver(wateringMachine));
        }

        private void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void MeasurementsChanged(int temp, int humidity, int windPower)
        {
            observers.ForEach(o=>o.Update(temp,humidity,windPower));
        }
    }
}