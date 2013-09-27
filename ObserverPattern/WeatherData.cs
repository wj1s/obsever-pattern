using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void MeasurementsChanged(int temp, int humidity, int windPower)
        {
            observers.ForEach(o=>o.Update(temp,humidity,windPower));
        }
    }
}