using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{

    class Account
    {
        private String accName;
        private String acid;
        private int balance;

        public String AccName
        {
            get
            {
                return accName;
            }
            set
            {
                accName = value;
            }
        }
        public String Acid
        {
            get
            {
                return acid;
            }
            set
            {
                acid = value;
            }
        }

        public int Balance
        {
            get
            {
                return balance;
            }
            set
            { balance = value; }
        }
        public int Deposit(int amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("Deposited Amount =" + amount);
            }
            else
            {
                Console.WriteLine("Sorry! Amount not Deposited ");
                Console.WriteLine(" Thank Your Staying Us");
            }
            return amount;

        }
        public int Withdraw(int amount)
        {
            if (amount <= balance)
            {
                Console.WriteLine("Amount  successfully withdrawed");
                Console.WriteLine(" Thank Your Staying Us");

            }
            else
            {
                Console.WriteLine("sorry! You do not have enough balance to withdraw");
                Console.WriteLine(" Thank Your Staying Us");
            }
            return amount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            acc.AccName = "Najmul Uddin NOman";
            acc.Acid = "1838293";
            acc.Balance = 13000;
            acc.Deposit(1500);
            acc.Withdraw(500);


        }
    }
}
