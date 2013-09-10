namespace ObserverPattern
{
    public class SeedingMachine
    {
        public bool Status { get; private set; }

        public void Start()
        {
            Status = true;
        }
    }
}