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
                    case 4:
                        Library.updateBook();
                        break;
                    case 5:
                        return;
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

    static List<book> _bookArr = new List<book>()
    {
        new book(){ bookId = 1, bookName = "Intersteller", category = "Sci-fi", bookCount = 10},
        new book{ bookId = 2, bookName = "Python", category = "Course", bookCount = 9},
        new book{ bookId = 3, bookName = "PHP Basics", category = "Course", bookCount = 11},
        new book{ bookId = 4, bookName = "Quran", category = "Islamic", bookCount = 100},
        new book{ bookId = 5, bookName = "Hadith", category = "Islamic", bookCount = 90},
    };

    static Library()
    {
        _userArr = new List<user>();
    }
    public static void showBooks()
    {
        /*var showBooks = new book[]
        {
            new book{ bookId = 1, bookName = "Intersteller", category = "Sci-fi", bookCount = 10},
            new book{ bookId = 2, bookName = "Python", category = "Course", bookCount = 9},
            new book{ bookId = 3, bookName = "PHP Basics", category = "Course", bookCount = 11},
            new book{ bookId = 4, bookName = "Quran", category = "Islamic", bookCount = 100},
            new book{ bookId = 5, bookName = "Hadith", category = "Islamic", bookCount = 90},
        };*/

        Console.WriteLine("Books Available are: ");

        foreach (var item in _bookArr)
        {
            Console.Write($"Name: {item.bookName}\t\tCateory: {item.category} \tCount: {item.bookCount}\n");
        }
    }

    public static void showUsers(String value)
    {

        if (value == "show")
        {
            Console.WriteLine("Users Available are: ");

            if (_userArr.Count > 0)
            {
                foreach (var item in _userArr)
                {
                    Console.Write($"UserName: {item.name} \t Day Count: " +
                        $"{item.dateCount} \t Books Available: {item.bookName}\n");
                }
            }
            else
            {
                Console.WriteLine("No users registered!!");
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

    public static void updateBook()
    {
        int book_id;
        Console.WriteLine("Enter bookId");
        book_id = Convert.ToInt32(Console.ReadLine());

        var found = _bookArr.FirstOrDefault(c => c.bookId == book_id);
        found.bookCount--;
        Console.WriteLine(found.bookCount);
        Console.WriteLine("Update successful!!");
    }
}