namespace ObserverPattern
{
    public class WateringMachine
    {
        public bool Status { get; private set; }

        public void Start()
        {
            Status = true;
        }
    }
}