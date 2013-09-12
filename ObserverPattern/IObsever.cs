namespace ObserverPattern
{
    public interface IObsever
    {
        void Update(int temp, int humidity, int windPower);
    }
}