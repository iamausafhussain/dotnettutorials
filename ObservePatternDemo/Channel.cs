namespace ObservePatternDemo
{
    public class Channel
    {
        private List<Subscriber> subscribers = new List<Subscriber>();
        public string title;

        public void Subscribe(Subscriber subscriber)
        {
            subscribers.Add(subscriber);
        }
        public void Unsubscribe(Subscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }
        public void NotifySubscribers()
        {
            foreach (Subscriber subscriber in subscribers)
            {
                subscriber.Update();
            }
        }
        public void Upload(string title)
        {
            this.title = title;
            NotifySubscribers();
        }
    }
}
