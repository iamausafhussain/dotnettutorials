namespace AtmSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AtmShow showInstance = AtmShow.GetShowInstance;
            AtmTransaction transactionInstance = AtmTransaction.GetTransactionInstance;

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
                            showInstance.showBalance();
                            break;
                        case 2:
                            showInstance.showHistory();
                            break;
                        case 3:
                            if (transaction_limit <= 10)
                            {
                                transactionInstance.createTransaction();
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


                                transactionInstance.cashDeposit();
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