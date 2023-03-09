namespace assignmentone
{
    /*----------------------------Question 1 to 10----------------------------*/
    public class Area
    {
        int length, bredth;
        public void setDim(int length, int bredth)
        {
            this.length = length;
            this.bredth = bredth;
        }

        public int getArea()
        {
            return (length * bredth);
        }
    }

    public class Student
    {
        String name;
        int roll_no;
        public Student(String name, int roll_no)
        {
            this.name = name;
            this.roll_no = roll_no;
        }
        public void Display() {
            Console.WriteLine($"name: {name}, Roll-no: {roll_no}");
        }
    }
    public class StudentTwo
    {
        public int roll_no;
        public String phone_no;
        public String address;

        public StudentTwo(int roll_no, String phone_no, String address){
            this.roll_no=roll_no;
            this.phone_no=phone_no;
            this.address=address;
        }

        public void display()
        {
            Console.WriteLine($"Roll-no {roll_no}, Phone-no {phone_no}, Address {address}");
        }

    }

    public class Triangle
    {
        public float a, b, c;
        public void SetDim(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
       public void Area() {

            double s = (this.a + this.b + this.c) / 2;
            double area = Math.Sqrt(s * (s - this.a) * (s - this.b) * (s - this.c));
            Console.WriteLine($"Area: {area}");
       }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter: {this.a + this.b + this.c}");
        }
    }

    public class Rectangle
    {
        int length;
        int bredth;

        public Rectangle(int length, int bredth)
        {
            this.length = length;
            this.bredth = bredth;   
        }
        public void Area()
        {
            int area = this.length * this.bredth;
            Console.WriteLine($"Area of Rectangle: {area}");
        }
    }

    public class Area1
    {
        int length;
        int bredth;
        public Area1(int length, int bredth)
        {
            this.length = length;
            this.bredth = bredth;
        }

        public int returnArea()
        {
            return this.length * this.bredth;
        }
    }

    public class Average
    {
        float number_one, number_two, number_three, average;
        public void setNumber(float number_one, float number_two, float number_three) {
            this.number_one = number_one;
            this.number_two = number_two;
            this.number_three = number_three;
        }

        public void calculateAverage()
        {
            this.average = (this.number_one + this.number_two + this.number_three) / 3;
        }
        public void printAverage()
        {
            Console.WriteLine($"Average: {this.average}");
        }
    }

    public class Complex
    {
        int real, img;
        public void setComplex(int real, int img)
        {
            this.real = real;
            this.img = img;
        }
        public void Sum(Complex c1, Complex c2)
        {
            this.real = c1.real + c2.real;
            this.img = c1.img + c2.img;

            Console.WriteLine($"Sum: {this.real} + {this.img}i");
        }
        public void Difference(Complex c1, Complex c2)
        {
            this.real = c1.real - c2.real;
            this.img = c1.img - c2.img;

            Console.WriteLine($"Difference: {this.real} + {this.img}i");
        }
        public void Multiply(Complex c1, Complex c2)
        {
            this.real = (c1.real * c2.real) - (c1.img * c2.img);
            this.img = (c1.real * c2.img) + (c1.img * c2.real);
            Console.WriteLine($"Multiply: {this.real} + {this.img}i");
        }
    }

    public class Employee
    {
        public String name, address;
        public int year_of_joining;
        public int salary;

        public Employee(String name, int year_of_joining, String address)
        {
            this.name = name;
            this.year_of_joining = year_of_joining;
            this.address = address;
        }

        public void Display()
        {
            Console.Write($"{this.name}\t\t{this.year_of_joining}\t\t\t{this.address}\n");
        }
    }

    public class AtmTransaction
    {
        public int current_balance, amount_withdrawal, cash_deposit;
        public void setInitialTransaction(int current_balance, int amount_withdrawal, int cash_deposit)
        {
            this.current_balance = current_balance;
            this.amount_withdrawal = amount_withdrawal;
            this.cash_deposit = cash_deposit;
        }

        public int CheckCurrentBalance()
        {
            if(this.current_balance == 0)
            {
                Console.WriteLine("Please Deposit Amount in your Account!!");
                return this.current_balance;
            }
            return this.current_balance;
        }

        public void AmountWithdrawal()
        {
            int amount;
            Console.WriteLine("Enter Amount to WithDraw: ");
            amount = Convert.ToInt32(Console.ReadLine());
            if (this.current_balance >= amount)
            {
                this.current_balance -= amount;
                Console.WriteLine($"Amount Withdrawn: {amount}");
                Console.WriteLine($"Your Current Balance: {this.current_balance}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance!!");
                Console.WriteLine("Please Deposit Amount in your Account!!");
            }
        }

        public void CashDeposit()
        {
            int amount;
            Console.WriteLine("Enter Amount to Deposit: ");
            amount = Convert.ToInt32(Console.ReadLine());
            this.current_balance += amount;

            Console.WriteLine($"Your Current Balance: {this.current_balance}");
        }
    }

    /* ----------------------------Question 11 to 20----------------------------*/

    public class Person
    {
        public String name;
        public int age;

        public void setPerson(String name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {this.name} and I'm {this.age} years old");
        }
    }

    public class StudentThree : Person
    {
        public String major;

        public void setStudentThree(String major)
        {
            this.major = major;
        }
        public void Study()
        {
            Console.WriteLine($"I'm studying {this.major}");
        }
    }

    public class Teacher : Person
    {
        public String subject;

        public void setTeacher(String subject)
        {
            this.subject = subject;
        }

        public void Teach()
        {
            Console.WriteLine($"I'm teaching {this.subject}");
        }
    }

    public class RectangleTwo
    {
        public float width, height;

        public RectangleTwo(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public float Area()
        {
            return this.width * this.height;
        }

        public float Perimeter()
        {
            return 2 * (this.width + this.height);
        }
    }

    public class Animal
    {
        public String name, species;
        public Animal(string name, string species)
        {
            this.name = name;
            this.species = species;
        }
        public void Speak()
        {
            if(this.species == "Dog")
            {
                Console.WriteLine($"'Woof'");
            }
            else if(this.species == "Bird")
            {
                Console.WriteLine($"'Chirp'");
            }
            else if (this.species == "Cat")
            {
                Console.WriteLine($"'Meoow'");
            }
        }
    }

    public class Cat : Animal
    {
        public String color;
        public Cat(string name, string species) : base(name, species)
        {
            this.name = name;
            this.species = species;
        }

        public void purr()
        {
            Console.WriteLine("purrrr!!");
        }

    }
    internal class Assignment
    {
        static void Main(string[] args)
        {
            /* ----------------------------Question 1 to 10----------------------------*/
            /*Question One*/

            /*Area rectangle = new Area();
            int length, bredth;
            Console.WriteLine("Enter the Length of Rectangle: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Bredth of Rectangle: ");
            bredth = Convert.ToInt32(Console.ReadLine());

            rectangle.setDim(length, bredth);
            int area = rectangle.getArea();
            Console.WriteLine($"This Area of Rectangle is: {area}");*/

            /*Question Two */
            /*Student student = new Student("John", 2);
            student.Display();*/

            /*Question Three */
            /*StudentTwo studentone = new StudentTwo(2, "1234567890", "BBSR");
            StudentTwo studentTwo = new StudentTwo(4, "0987654321", "PRI");
            studentone.display();
            studentTwo.display();*/

            /*Question Four */

            /*Triangle triangle = new Triangle();
            triangle.SetDim(5, 10, 12);
            triangle.Area();
            triangle.Perimeter();*/

            /*Question Five */
            /*Rectangle rectangle = new Rectangle(4, 5);
            Rectangle rectangle1 = new Rectangle(5, 8);
            rectangle.Area();
            rectangle1.Area();*/

            /*Question Six */
            /*int length, bredth, area;
            Console.WriteLine("Enter Length of Rectangle: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Bredth of Rectangle: ");
            bredth = Convert.ToInt32(Console.ReadLine());
            Area1 rectangle = new Area1(length, bredth);
            area = rectangle.returnArea();

            Console.WriteLine($"Area: {area}");*/

            /*Question Seven */
            /*Average average = new Average();
            float number_one, number_two,number_three;
            Console.WriteLine("Enter number One");
            number_one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number Two");
            number_two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number Three");
            number_three = Convert.ToInt32(Console.ReadLine());
            average.setNumber(number_one, number_two, number_three);    
            average.calculateAverage();
            average.printAverage();*/

            /*Question Eight */
            /*int real, img, real2, img2;
            Console.WriteLine("Enter real and img (a + bi) part of first Complex number: ");
            real = Convert.ToInt32(Console.ReadLine());
            img = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter real and img (a + bi) part of second Complex number: ");
            real2 = Convert.ToInt32(Console.ReadLine());
            img2 = Convert.ToInt32(Console.ReadLine());
            Complex c1 = new Complex();
            Complex c2 = new Complex();
            Complex c3 = new Complex();
            c1.setComplex(real, img);
            c2.setComplex(real2, img2);
            c3.Sum(c1, c2);
            c3.Difference(c1, c2);
            c3.Multiply(c1, c2);*/

            /*Question Nine */
            /*Employee employee_one = new Employee("Robert", 1994, "64-C WallStreet");
            Employee employee_two = new Employee("Sam", 2000, "68-DC WallStreet");
            Employee employee_three = new Employee("John", 1999, "26-B WallStreet");
            Console.WriteLine($"Name\t\tYear of joining\t\tAddress");
            employee_one.Display();
            employee_two.Display();
            employee_three.Display();*/

            /*Question Ten */
            /*AtmTransaction transaction = new AtmTransaction();
            int choice;
            Console.WriteLine("______________WELCOME____________");

            do
            {
                Console.WriteLine("\nPress:\n1.For Checking Current Balance\n2.Amount Withdrawal\n3.Cash Deopsit\n4.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int balance;
                        balance = transaction.CheckCurrentBalance();
                        Console.WriteLine($"Your Current Balance is: {balance}");
                        break;
                    case 2:
                        transaction.AmountWithdrawal();
                        break;
                    case 3:
                        transaction.CashDeposit();
                        break;
                    case 4: break;
                    default:
                        Console.WriteLine("Incorrect Input!!\nTransaction Failed!! ");
                        break;
                }
            } while (choice == 1 || choice == 2 || choice == 3);*/


            /* ----------------------------Question 11 to 20----------------------------*/

            /*Question 11*/
            /*Person person = new Person();
            person.setPerson("Ausaf", 22);
            person.Introduce();*/

            /*Question 12*/
            /*StudentThree student = new StudentThree();
            student.setStudentThree("CSE");
            student.Study();*/

            /*Question 13*/
            /*Teacher teacher = new Teacher();
            teacher.setTeacher("Maths");
            teacher.Teach();*/

            /*Question 14*/
            /*RectangleTwo rectangle = new RectangleTwo(4, 10);
            float area = rectangle.Area();
            float perimeter = rectangle.Perimeter();

            Console.WriteLine($"Area: {area}, Perimeter: {perimeter}");*/

            /*Question 15*/
            /*Animal animal = new Animal("Kitty", "Dog");
            animal.Speak();*/

            /*Question 16*/
            /*Cat cat = new Cat("Kitty", "Cat");
            cat.purr();*/
        }
    }
}