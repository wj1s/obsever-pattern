namespace ObserverPattern
{
    public class SeedingMachineObserver : IObserver
    {
        private SeedingMachine seedingMachine;

        public SeedingMachineObserver(SeedingMachine seedingMachine)
        {
            this.seedingMachine = seedingMachine;
        }

        public void Update(int temp, int humidity, int windPower)
        {
            if (temp > 5)
                seedingMachine.Start();
        }
    }
}