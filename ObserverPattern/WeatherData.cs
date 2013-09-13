using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData
    {
        private List<IObsever> obsevers = new List<IObsever>();

        public void Subscribe(IObsever obsever)
        {
            obsevers.Add(obsever);
        }

        public void MeasurementsChanged(int temp, int humidity, int windPower)
        {
            obsevers.ForEach(o=>o.Update(temp,humidity,windPower));
        }
    }
}