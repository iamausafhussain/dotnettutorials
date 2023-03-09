namespace chatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String user_input;

            Console.WriteLine("Hi, What's your name");
            user_input = Console.ReadLine();
            User user = new User();
            user.getString(user_input);
        }
    }
}

class User
{
    String name;
    public void getString(string input)
    {
        this.name = input;
        Console.WriteLine($"{name} How is Everything going");

        input = Console.ReadLine();
        if(input == "good" || input == "nice")
        {
            Console.WriteLine("That's awesome to hear!!");
        }
        else
        {
            Console.WriteLine("How can I make your day Good!!");
        }
        Console.WriteLine("Can I say you a joke!!");
        input = Console.ReadLine();
        if (input.Contains("joke") || input.Contains("yes"))
        {
            Console.WriteLine("What’s the best thing about Switzerland?");
            Console.WriteLine("The flag is a big plus!!");
        }
        else
        {
            Console.WriteLine("Can I Do something for you!!");
        }
        Console.WriteLine($"What's now {name}");

        input = Console.ReadLine();

        if (input.Contains("bye"))
        {
            Console.WriteLine("Good Bye!!");
        }
        else
        {
            Console.WriteLine("See you later!!");
        }
    }
}