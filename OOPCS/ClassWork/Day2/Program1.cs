using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{

    class Product1
    {
        //attributes
        string name;//by default it  is private 
        string id;//by default it  is private 
        int quantity;//by default it  is private 

        //constuctors

        // this constructor is same as the above but here we are using this key word
        public Product1(string name, string id, int quantity)
        {
            this.name = name;
            this.id = id;
            this.quantity = quantity;

        }

        public Product1(string n, string i)
        {
            name = n;
            id = i;
            Quantity = 1;

        }

        /*     public Product()
             {
                 name = "";
                 id = "0000";
                 quantity = 0;

             }*/




        //properties
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value > 0)
                    quantity = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
        //methods

        public void Restock(int quantity)
        {
          //  this.quantity = this.quantity + q;//q is parameter passed in Restock
        }
        public string Show()
        {
            return String.Format("Product:{0},{1},{2}", Name, Id, Quantity);
        }
        public void DoSomething()
        {
            Console.WriteLine("Called DoSomethig()");
        }

    }

    class Customer1
    {

    }

    class ProgramThis
    {
        static void Main(string[] args)
        {
            Product1 a = new Product1("Table", "P10001", 20);
            Product1 b = new Product1("Chair", "P10002", 20);
            Customer c = new Customer();
            Console.WriteLine(a.Show());
            a.Restock(12);
            Console.WriteLine(a.Show());

        }
    }
}
