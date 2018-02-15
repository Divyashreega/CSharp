using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{

    class Product
    {
        //attributes
        string name;//by default it  is private 
        string id;//by default it  is private 
        int quantity;//by default it  is private 

        //constuctors
        public Product(string n, string i, int q)
        {
            name = n;
            id = i;
            Quantity = q;

        }

        // this constructor is same as the above but here we are using this key word


        public Product(string n, string i)
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

        public void Restock(int q)
        {
            Quantity = Quantity + q;//q is parameter passed in Restock
        }

        public string Show()
        {
            return String.Format("Product:{0},{1},{2}", Name, Id, Quantity);
        }
    }

    class Customer
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Product a = new Product("Table", "P10001", 20);
            Product b = new Product("Chair", "P10002", 20);
            Customer c = new Customer();
            Console.WriteLine(a.Show());
            a.Restock(12);
            Console.WriteLine(a.Show());

        }
    }
}
