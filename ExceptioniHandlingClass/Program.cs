using System.Text.RegularExpressions;

namespace ExceptioniHandlingClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag = 0, second_flag = 0;
            User user = new User();


            while (second_flag != 1)
            {
                try
                {
                    if (flag == 0)
                    {
                        flag = 1;
                        user.validateUser("ausafhussain010@gmail.com");
                    }
                    else
                    {
                        second_flag = 1;
                        user.validatePassword("hello");
                    }
                }
                catch (CustomExceptionHandler e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}

public class CustomExceptionHandler : Exception
{
    public CustomExceptionHandler(String message) : base(message) { }
}

public class User
{
    public void validateUser(string username)
    {
        string pattern = "ausaf";
        Regex regex = new Regex(pattern);

        if (!regex.IsMatch(username))
            throw new CustomExceptionHandler("Your email is invalid!");
        else
            Console.WriteLine("Valid username!");
    }

    public void validatePassword(string password)
    {
        if (password.Length < 8)
            throw new CustomExceptionHandler("Your password length is less than 8 characters!");
        else
            Console.WriteLine("Valid password!");
    }
}
