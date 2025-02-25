namespace KataEventAndDelegate
{
    public class PersonEventArgs : EventArgs
    {
        // implement custom event handler with Name property (string)
    }

    public class Publisher
    {
        public event /*delegate*/ ContactNotify;


        public void CountMessages(List<string> peopleList)
        {
            foreach (string person in peopleList)
            {
                // implement your logic to send name of people after appearing 3*n times
                OnContactNotify(person); // Notify subscribers
            }
        }
    }
}