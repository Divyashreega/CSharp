using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Account
    {
        string accountnumber;
        string name;
        double balance;


        public Account(string a, string n, double bal)

        {
            accountnumber = a;
            name = n;
            balance = bal;

        }

        public string Accountnumber
        {

            get
            {
                return accountnumber;
            }
        }

        public string Name
        {

            get
            {
                return name;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value > 0)

                    balance = value;

            }

        }

        public void Deposit(double amt)
        {
            balance = balance + amt;

        }

        public void Withdraw(double amt)
        {
            if (amt > balance)
            {
                Console.WriteLine("Not sufficient balance");
            }
            else
            {
                Console.WriteLine("sufficient balance");
                balance = balance - amt;
                Console.WriteLine(balance);

            }
        }

        public void TransferTo(double amt, Account b)
        {
            Withdraw(amt);

            b.Deposit(amt);

            // balance = balance + amt;//we should nnt do because it adding again to a only

            // b.balance = b.balance + amt;//works good.same as b.deposit


        }
        public string Show()
        {
            return String.Format("Account {0},{1},{2}", accountnumber, name, balance);
            // Console.WriteLine("Account {0},{1},{2}", accountnumber, name, balance);
        }
        class BankTest
        {
            static void Main()
            {
                Account a = new Account("001-001-001", "Tan", 2000);
                Account b = new Account("001-001-002", "Kim", 5000);
                Console.WriteLine(a.Show());
                Console.WriteLine(b.Show());
                a.Deposit(100);
                Console.WriteLine(a.Show());
                a.Withdraw(200);
                Console.WriteLine(a.Show());
                a.TransferTo(300, b);
                Console.WriteLine(a.Show());
                Console.WriteLine(b.Show());
                Customer x = new Customer("aa", "ss", "e343d", new DateTime(1989, 10, 11));
                Console.WriteLine(x.GetAge());


            }
        }
    }
}
