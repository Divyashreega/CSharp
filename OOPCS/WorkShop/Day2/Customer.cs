using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class BankAccount
    {
        string accountnumber;
        Customer name;
        double balance;


        public BankAccount(string a, Customer n, double bal)

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

        public Customer Name
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
                // Console.WriteLine("sufficient balance");
                balance = balance - amt;
                // Console.WriteLine(balance);

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
    }
    class Customer
    {
        string name;
        string address;
        string passportNumber;
        DateTime date;

        public Customer(string n, string add, string pass, DateTime d)
        {
            name = n;
            address = add;
            passportNumber = pass;
            date = d;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
        }

        public string PassportNumber
        {
            get
            {
                return passportNumber;
            }
        }


        public DateTime Date
        {
            get
            {
                return date;
            }
        }


        public int GetAge()
        {

            DateTime currentdate = DateTime.Today;
            int age = currentdate.Year - date.Year;
            Console.WriteLine(age);
            return age;
        }
    }
    class Banktest2
    {
        static void Main()
        {
            Customer y = new Customer("Tan", "20,seaside Road", "XXX20", new DateTime(1989, 10, 11));
            Customer z = new Customer("Lee", "2,Rich View", "XXX9F", new DateTime(1999, 4, 25));
            Account a = new Account("001-001-001", "y", 2000);
            Account b = new Account("002-002-002", "z", 2000);
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
            a.Deposit(100);
            Console.WriteLine(a.Show());
            a.Withdraw(200);
            Console.WriteLine(a.Show());
            a.TransferTo(300, b);
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
            Console.WriteLine(y.GetAge());



        }
    }
}
