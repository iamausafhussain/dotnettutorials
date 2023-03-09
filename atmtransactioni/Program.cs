using System.Collections;
using System;
using System.Linq;
using System.Collections.Generic;

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
                        case 1: transaction.showBalance();
                            break;
                        case 2: transaction.showHistory();
                            break;
                        case 3:
                            if(transaction_limit <= 10)
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
                            if(transaction_limit <= 10)
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

class ATM
{
    private int balance, current_amount;
    int withdrawal_count = 0, prev_transaction_count = 0;

    int[] prev_transaction_arr = new int[10];

    List<int> new_prev_transaction = new List<int>();
    public void showBalance()
    {
        Console.WriteLine($"Your Available Balance is {this.balance}");
    }

    public void showHistory()
    {
        var prev_transaction = new ArrayList();
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

    public void createTransaction()
    {
        Console.WriteLine("Enter Amount to withdraw: ");
        this.current_amount = Convert.ToInt32(Console.ReadLine());
        if(this.balance >= this.current_amount && this.current_amount <= 1000)
        {
            this.balance -= this.current_amount;
            this.withdrawal_count++;
            this.new_prev_transaction.Add(this.current_amount);
            this.prev_transaction_count++;
            Console.WriteLine("Your last transaction was successful!!");
        }
        else if(this.balance >= this.current_amount && this.current_amount > 1000)
        {
            Console.WriteLine("Please Input Amount less than 1000");
        }
        else
        {
            Console.WriteLine("Insufficient Balance!!");
        }
    }

    public void cashDeposit()
    {
        Console.WriteLine("Enter amount to deposit");
        int amount = Convert.ToInt32(Console.ReadLine());

        this.balance += amount;
    }
}