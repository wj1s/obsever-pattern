namespace ObserverPattern
{
    public class ReapingMachineObserver:IObserver
    {
        private ReapingMachine reapingMachine;

        public ReapingMachineObserver(ReapingMachine reapingMachine)
        {
            this.reapingMachine = reapingMachine;
        }

        public void Update(int temp, int humidity, int windPower)
        {
            if (temp > 5 & humidity > 65)
                reapingMachine.Start();
        }
    }
}