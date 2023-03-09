namespace secondproject
{
    class Login
    {
        public Boolean checkPassword(string password)
        {
            String current_password = "qwerty";
            if(password == current_password)
            {
                return true;
            }
            return false;
        }

        public void printStanga(int number)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}\n");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Login user = new Login();
            String read_passsword;
            Boolean isPasswordCorrect;
            int count=3;
            String ch="";

            Console.WriteLine("---------------------------Welcome---------------------------");

            do{
                Console.WriteLine("\nEnter your password");
                read_passsword = Console.ReadLine();

                isPasswordCorrect = user.checkPassword(read_passsword);

                if (isPasswordCorrect){
                    Console.WriteLine("Correct Password!!");
                    do
                    {
                        int number;
                        Console.WriteLine("\nEnter a number to print its Table:");
                        number = Convert.ToInt32(Console.ReadLine());

                        user.printStanga(number);

                        Console.WriteLine("To continue? Press 'Y'/ 'YES'/ 'y'/ 'yes'/ or Press any other key to exit");
                        ch = Console.ReadLine();

                    } while (ch == "y" || ch == "yes" || ch == "YES" || ch == "Y");
                    Console.WriteLine("Thank you");
                    break;
                }
                else{
                    Console.WriteLine("Incorrect Password!!");
                    count--;
                    Console.WriteLine($"\n{count} Attempts remaining!!");
                }
            } while (count > 0);
        }
    }
}