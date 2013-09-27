using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData
    {
        private readonly ReapingMachine reapingMachine;
        private readonly SeedingMachine seedingMachine;
        private readonly WateringMachine wateringMachine;
        private List<IObserver> observers = new List<IObserver>();

        public WeatherData(SeedingMachine seedingMachine, ReapingMachine reapingMachine, WateringMachine wateringMachine)
        {
            this.seedingMachine = seedingMachine;
            this.reapingMachine = reapingMachine;
            this.wateringMachine = wateringMachine;
            SetObservers();

        }

        public void MeasurementsChanged(int temp, int humidity, int windPower)
        {
            observers.ForEach(o=>o.Update(temp,humidity,windPower));
        }

        private void SetObservers()
        {
            observers.Add(new SeedingMachineObserver(seedingMachine));
            observers.Add(new ReapingMachineObserver(reapingMachine));
            observers.Add(new WateringMachineObserver(wateringMachine));
        }
    }
}