namespace ObservePatternDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel();

            Subscriber obj1 = new Subscriber("Ausaf");
            Subscriber obj2 = new Subscriber("Fahad");
            Subscriber obj3 = new Subscriber("Allen");

            channel.Subscribe(obj1);
            channel.Subscribe(obj2);
            channel.Subscribe(obj3);

            obj1.SubscribeChannel(channel);
            obj2.SubscribeChannel(channel);
            obj3.SubscribeChannel(channel);

            channel.Upload("PHP Basics");
        }
    }
}