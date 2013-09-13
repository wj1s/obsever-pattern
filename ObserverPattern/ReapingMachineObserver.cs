namespace ObserverPattern
{
    public class ReapingMachineObserver
    {
        private ReapingMachine reapingMachine;

        public ReapingMachineObserver(ReapingMachine reapingMachine)
        {
            this.reapingMachine = reapingMachine;
        }

        public void ReapingMachineUpdate(int temp, int humidity)
        {
            if (temp > 5 & humidity > 65)
                reapingMachine.Start();
        }
    }
}