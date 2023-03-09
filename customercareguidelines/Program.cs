namespace customercareguidelines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 1, user_choice;
            do {
                switch (choice) {
                    case 1:
                        Console.WriteLine("\nPress 1 to Talk to our Customer Care Executive.");
                        Console.WriteLine("Press 2 to get your Main Balance.");
                        Console.WriteLine("Press 3 to get Credit card related queries.");
                        Console.WriteLine("Press 4 to get Debit card related queries.");
                        Console.WriteLine("Press 5 to change your PIN.");
                        Console.Write("Enter your choice: \t");
                        user_choice = Convert.ToInt32(Console.ReadLine());
                        switch (user_choice)
                        {
                            case 1: Console.WriteLine("\nCalling to Executive...");
                                return;
                            case 2: Console.WriteLine("Your main balance is 2000");
                                return;
                            case 3: int cred_details;
                                Console.WriteLine("\nPress 1 to Create Credit Card.");
                                Console.WriteLine("Press 2 to block your Credit Card");
                                Console.WriteLine("Press 3 to change your Credentials");
                                Console.WriteLine("Press 4 to go to Main Menu");
                                user_choice = Convert.ToInt32(Console.ReadLine());

                                switch (user_choice)
                                {
                                    case 1: String name, card_no;
                                        Console.WriteLine("\nEnter Your Name:");
                                        name = Console.ReadLine();
                                        Console.WriteLine("Enter Your CardNo:");
                                        card_no = DateTime.UtcNow.Ticks.ToString().Substring(8);

                                        Console.WriteLine($"Your Credit Card has been created with details:\nName: {name}\t{card_no}");
                                        return;
                                    case 2:
                                        Console.WriteLine("\nEnter your CardNo:");
                                        Console.WriteLine("Your card has been blocked");
                                        return;
                                    case 3:
                                        Console.WriteLine("\nEnter your CardNo:");
                                        Console.WriteLine("Enter your name:");
                                        name = Console.ReadLine();

                                        Console.WriteLine($"Your Credentials has been changed to {name}!!");
                                        return;
                                    case 4: break ;
                                }
                                break;
                            case 4:
                                Console.WriteLine("\nPress 1 to Create Debit Card.");
                                Console.WriteLine("Press 2 to block your Debit Card");
                                Console.WriteLine("Press 3 to change your Credentials");
                                Console.WriteLine("Press 4 to go to Main Menu");
                                Console.WriteLine("Enter Your choice");
                                user_choice = Convert.ToInt32(Console.ReadLine());
                                switch (user_choice)
                                { 
                                    case 1:
                                        String name, card_no;
                                        Console.WriteLine("\nEnter Your Name:");
                                        name = Console.ReadLine();
                                        Console.WriteLine("Enter Your CardNo:");
                                        card_no = DateTime.UtcNow.Ticks.ToString().Substring(8);

                                        Console.WriteLine($"Your Debit Card has been created with details:\nName: {name}\t{card_no}");
                                        return;
                                    case 2:
                                        Console.WriteLine("\nEnter your CardNo:");
                                        Console.WriteLine("Your card has been blocked");
                                        return;
                                    case 3:
                                        Console.WriteLine("\nEnter your CardNo:");
                                        Console.WriteLine("Enter your name:");
                                        name = Console.ReadLine();

                                        Console.WriteLine($"Your Credentials has been changed to {name}!!");
                                        return;
                                    case 4: break;
                                }
                                break ;

                            case 5:
                                int old_pin=0101, pin, new_pin, confirm_pin;
                                Console.WriteLine("Enter Your Previous PIN");
                                pin = Convert.ToInt32(Console.ReadLine());

                                if(pin != old_pin)
                                {
                                    Console.WriteLine("Incorrect PIN!!");
                                }
                                else
                                {
                                    Console.WriteLine("Enter new PIN");
                                    new_pin = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter PIN again!!");
                                    confirm_pin = Convert.ToInt32(Console.ReadLine());
                                    if(new_pin == confirm_pin)
                                    {
                                        Console.WriteLine("Your PIN has been reset!!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Confirn pin does not match!!");
                                    }
                                }
                                break;     
                        }
                        break;
                    

                }
            } while(true);
        }
    }
}

class customerCare
{

}