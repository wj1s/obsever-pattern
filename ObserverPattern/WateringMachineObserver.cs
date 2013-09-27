namespace ObserverPattern
{
    public class WateringMachineObserver : IObserver
    {
        private readonly WateringMachine wateringMachine;

        public WateringMachineObserver(WateringMachine wateringMachine)
        {
            this.wateringMachine = wateringMachine;
        }

        public void Update(int temp, int humidity, int windPower)
        {
            if (temp > 10 && humidity < 55 && windPower < 4)
                wateringMachine.Start();
        }
    }
}