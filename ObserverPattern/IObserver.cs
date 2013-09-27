namespace ObserverPattern
{
    public interface IObserver
    {
        void Update(int temp, int humidity, int windPower);
    }
}