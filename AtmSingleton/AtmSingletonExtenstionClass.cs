namespace AtmSingleton
{

    public sealed class AtmShow
    {
        public static int balance, current_amount;
        public static int withdrawal_count = 0;
        public static List<int> new_prev_transaction = new List<int>();

        public static AtmShow showInstance = null;
        public static AtmShow GetShowInstance
        {
            get
            {
                if (showInstance == null)
                    showInstance = new AtmShow();
                return showInstance;
            }
        }

        public bool showBalance()
        {
            if (AtmShow.balance >= 0)
            {
                Console.WriteLine($"Your Available Balance is {AtmShow.balance}");
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
            if (AtmShow.withdrawal_count == 0)
            {
                Console.WriteLine("No prev History available!!");
            }
            else
            {
                var res = AtmShow.new_prev_transaction.Reverse<int>().Take(3);
                foreach (int a in res)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }

    public sealed class AtmTransaction
    {
        public static AtmTransaction transactionInstance = null;
        public static AtmTransaction GetTransactionInstance
        {
            get
            {
                if (transactionInstance == null)
                    transactionInstance = new AtmTransaction();
                return transactionInstance;
            }
        }

        public bool createTransaction()
        {
            Console.WriteLine("Enter Amount to withdraw: ");
            AtmShow.current_amount = Convert.ToInt32(Console.ReadLine());
            if (AtmShow.balance >= AtmShow.current_amount && AtmShow.current_amount <= 1000 && AtmShow.current_amount > 0)
            {
                AtmShow.balance -= AtmShow.current_amount;
                AtmShow.withdrawal_count++;
                AtmShow.new_prev_transaction.Add(AtmShow.current_amount);
                Console.WriteLine("Your last transaction was successful!!");
                return true;
            }
            else if (AtmShow.balance >= AtmShow.current_amount && AtmShow.current_amount > 1000 && AtmShow.current_amount > 0)
            {
                Console.WriteLine("Please Input Amount less than 1000");
                return true;
            }
            else if (AtmShow.current_amount <= 0)
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
                    AtmShow.balance += amount;
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
}
