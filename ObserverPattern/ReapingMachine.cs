namespace ObserverPattern
{
    public class ReapingMachine
    {
        public bool Status { get; private set; }

        public void Start()
        {
            Status = true;
        }
    }
}