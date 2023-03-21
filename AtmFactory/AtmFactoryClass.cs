namespace AtmFactory
{
    public class AtmFactoryClass
    {
        public static IShow getObjectShow(string objectType)
        {
            IShow showObj = null;
            if (objectType.ToLower() == "show")
            {
                showObj = new AtmShow();
            }
            else
            {
                Console.WriteLine("Invalid Object Type Detected!");
            }
            return showObj;
        }

        public static ICreateTransaction getObjectTransaction(string objectType)
        {
            ICreateTransaction transactionObj = null;
            if (objectType.ToLower() == "transaction")
            {
                transactionObj = new AtmTransaction();
            }
            else
            {
                Console.WriteLine("Invalid Object Type Detected!");
            }
            return transactionObj;
        }
    }

    public interface IShow
    {
        public bool showBalance();
        public void showHistory();
    }

    public interface ICreateTransaction
    {
        public bool createTransaction();
        public bool cashDeposit();
    }

    public class AtmShow : IShow
    {
        public static int balance, current_amount;
        public static int withdrawal_count = 0;


        public static List<int> new_prev_transaction = new List<int>();
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

    public class AtmTransaction : ICreateTransaction
    {
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
