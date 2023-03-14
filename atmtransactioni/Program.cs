namespace atmtransaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM transaction = new ATM();
            String current_card_no = "100120023003", card_no, user_input;
            int transaction_limit = 0, choice, pin, current_pin = 1234;


            Console.WriteLine("Enter you Card Number: ");
            card_no = Console.ReadLine();

            Console.WriteLine("Enter your 4 digit PIN");
            pin = Convert.ToInt32(Console.ReadLine());

            if (card_no == current_card_no && pin == current_pin)
            {
                do
                {
                    Console.WriteLine("\n\nPress\n1. Show Available Balance\n2. Previous 3 Transactions" +
                        "\n3. Cash Withdrawal\n4. Cash Deopsit\n5. Exit\n");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            transaction.showBalance();
                            break;
                        case 2:
                            transaction.showHistory();
                            break;
                        case 3:
                            if (transaction_limit <= 10)
                            {
                                transaction.createTransaction();
                                transaction_limit++;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Transaction limit reached!!");
                                break;
                            }

                        case 4:
                            if (transaction_limit <= 10)
                            {


                                transaction.cashDeposit();
                                transaction_limit++;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Transaction limit reached!!");
                                break;
                            }
                        case 5:
                            Console.WriteLine("Your transaction has been cancelled");
                            return;
                        default:
                            Console.WriteLine("Your transaction has been cancelled");
                            return;
                    }
                    Console.WriteLine("\nPress y/Y to continue or Press any other to exit");
                    user_input = Console.ReadLine();
                } while (user_input == "y" || user_input == "Y");
            }
            else
            {
                Console.WriteLine("Invalid Credentials!!");
            }
            Console.WriteLine("Your last transaction has been cancelled!!");
            Console.WriteLine("Thank You!!");
        }
    }
}

public class ATM
{
    public int balance, current_amount;
    int withdrawal_count = 0;

    List<int> new_prev_transaction = new List<int>();
    public bool showBalance()
    {
        if (this.balance >= 0)
        {
            Console.WriteLine($"Your Available Balance is {this.balance}");
            return true;
        }
        else
        {
            Console.WriteLine("Your balance is less than 0!!");
            return false;
        }
    }

    public void showHistory()
    {
        if (this.withdrawal_count == 0)
        {
            Console.WriteLine("No prev History available!!");
        }
        else
        {
            var res = this.new_prev_transaction.Reverse<int>().Take(3);
            foreach (int a in res)
            {
                Console.WriteLine(a);
            }
        }
    }

    public bool createTransaction()
    {
        Console.WriteLine("Enter Amount to withdraw: ");
        this.current_amount = Convert.ToInt32(Console.ReadLine());
        if (this.balance >= this.current_amount && this.current_amount <= 1000 && this.current_amount > 0)
        {
            this.balance -= this.current_amount;
            this.withdrawal_count++;
            this.new_prev_transaction.Add(this.current_amount);
            Console.WriteLine("Your last transaction was successful!!");
            return true;
        }
        else if (this.balance >= this.current_amount && this.current_amount > 1000 && this.current_amount > 0)
        {
            Console.WriteLine("Please Input Amount less than 1000");
            return true;
        }
        else if (this.current_amount <= 0)
        {
            Console.WriteLine("Invalid Amount Entered!!");
            return false;
        }
        else
        {
            Console.WriteLine("Insufficient Balance!!");
            return false;
        }
    }

    public bool cashDeposit()
    {
        Console.WriteLine("Enter amount to deposit");

        try
        {
            int amount = Convert.ToInt32(Console.ReadLine());

            if (amount > 0)
            {
                this.balance += amount;
                return true;
            }
            else
            {
                Console.WriteLine("Invalid amount Entered!");
                return false;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Incorrect Value Entered!");
            return false;
        }


    }
}