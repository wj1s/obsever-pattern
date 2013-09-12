namespace ObserverPattern
{
    public class SeedingMachineObsever : IObsever
    {
        private SeedingMachine seedingMachine;

        public SeedingMachineObsever(SeedingMachine seedingMachine)
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