using sealedPro;

namespace sealedPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            String ch;
            Console.WriteLine("-----------------------Welcome to Library-----------------------\n\n");
            /*Library library = new Library();*/

            /*bookPro book = new bookPro();*/


            do
            {
                Console.WriteLine("\nPress \n1. Show Books\n2. Show User\n3. Add User\n4. Update Books\n5. Exit\n");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Library.showBooks();
                        break;
                    case 2:
                        Library.showUsers("show");
                        break;
                    case 3:
                        Library.showUsers("add");
                        break;
                    /*case 4:
                        library.updateUsers();
                        break;*/
                    default:
                        Console.WriteLine("Incorrect Input:\n");
                        return;
                }
                Console.WriteLine("\nPress y/Y to continue (or any other key to exit)");
                ch = Console.ReadLine();
            } while (ch == "Y" || ch == "y");

            Console.WriteLine("\n\n");
        }
    }
}

static class Library
{
    static List<user> _userArr;

    static Library()
    {
        _userArr = new List<user>();
    }
    public static void showBooks()
    {
        var showBooks = new book[]
        {
            new book{ bookId = 1, bookName = "Intersteller", category = "Sci-fi", bookCount = 10},
            new book{ bookId = 2, bookName = "Python", category = "Course", bookCount = 9},
            new book{ bookId = 3, bookName = "PHP Basics", category = "Course", bookCount = 11},
            new book{ bookId = 4, bookName = "Quran", category = "Islamic", bookCount = 100},
            new book{ bookId = 5, bookName = "Hadith", category = "Islamic", bookCount = 90},
        };

        Console.WriteLine("Books Available are: ");

        foreach (var item in showBooks)
        {
            Console.Write($"{item.bookName}\n");
        }
    }

    public static void showUsers(String value)
    {

        if (value == "show")
        {
            Console.WriteLine("Users Available are: ");
            foreach (var item in _userArr)
            {
                Console.Write($"UserName: {item.name} \t Day Count: " +
                    $"{item.dateCount} \t Books Available: {item.bookName}\n");
            }
        }
        else if (value == "add")
        {
            String user_name, book_name; int date_count;
            Console.WriteLine("Enter username:");
            user_name = Console.ReadLine();
            Console.WriteLine("Enter bookname:");
            book_name = Console.ReadLine();
            _userArr.Add(new user() { name = user_name, dateCount = 1, bookName = book_name });


            user[] users = _userArr.ToArray<user>();

            Console.WriteLine("User Added");
            foreach (var item in users)
            {
                Console.Write($"UserName: {item.name} \t Day Count: " +
                    $"{item.dateCount} \t Books Available: {item.bookName}\n");
            }
        }
    }
}