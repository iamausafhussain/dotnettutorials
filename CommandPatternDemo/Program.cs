namespace CommandPatternDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter on/off");
            string user_input = Console.ReadLine();
            Light lamp_obj = new Light();
            Switch switch_obj = new Switch();

            if (user_input == "on")
            {
                ICommand switch_up = new FlipUpCommand(lamp_obj);
                switch_obj.StoreAndExecute(switch_up);
            }
            else if (user_input == "off")
            {
                ICommand switch_down = new FlipDownCommand(lamp_obj);
                switch_obj.StoreAndExecute(switch_down);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}