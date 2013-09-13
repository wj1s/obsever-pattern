namespace ObserverPattern
{
    public class SeedingMachineObsever
    {
        private SeedingMachine seedingMachine;

        public SeedingMachineObsever(SeedingMachine seedingMachine)
        {
            this.seedingMachine = seedingMachine;
        }

        public void SeedingMachineUpdate(int temp)
        {
            if (temp > 5)
                seedingMachine.Start();
        }
    }
}