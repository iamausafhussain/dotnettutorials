namespace ObservePatternDemo
{
    public class Subscriber
    {
        private string name;
        private Channel channel = new Channel();
        public Subscriber(string name)
        {
            this.name = name;
        }
        public void Update()
        {
            Console.WriteLine($"Hi {name}, New Video Uploaded, {channel.title}");
        }
        public void SubscribeChannel(Channel channel)
        {
            this.channel = channel;
        }
    }
}
