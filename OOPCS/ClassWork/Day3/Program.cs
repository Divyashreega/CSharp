using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
   
    class Order
    {
        //Product[] items = new Product[10];
        Product[] items;
        int count;
        public Order(int n)
        {
            count = 0;
            items = new Product[n];

        }
        public void Add(Product p)
        {
            items[count] = p;
            count = count + 1;
        }

        public double TotalPrice()
        {
            double total = 0;
            for(int i=0;i<count;i++)
            {
                total = total + items[i].Price;
            }
            return total;
        }

        public double Print()
        {
            
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i].Show());
            }
            //return total;
        }
    }

         class Customer
    {
        string name;
        Order order;
        static int numberOfCustomers = 0;

        public Customer(string name)
        {
            this.name = name;
            order = new Order(8);
            numberOfCustomers = numberOfCustomers + 1;
        }
        public void Buy(Product p)
        {
            order.Add(p);
        }
        public void PrintOrders()
        {
            order.Print();
        }
        public double CostOfPurchase()
        {
            return order.TotalPrice();
        }
    }
        class Product
        {
            string id;
            string name;
            double price;

            public Product(string id, string name, double price)
            {
                this.id = id;
                this.name = name;
                this.price = price;


            }

            public string Id
            {
                get { return id; }
            }

            public string Name
            {
                get { return name; }
            }

            public double Price
            {
                get { return price; }
            }

            public string Show()
            {
                return String.Format("Product [{0},{1},{2}]", id, name, price);

            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("Tan");
            Order order = new Order(8);
            Product a = new Product("P1001","Table",150);
            Product b = new Product("P1002", "Chair",50);
            c.Buy(a);
            c.Buy(b);
            c.PrintOrders();
            Console.WriteLine(c.CostOfPurchase());
            order.Add(a);
            order.Add(b);

        

            string v = "123";
            Console.WriteLine(v);

           // string w = null;
           // Console.WriteLine(w.ToUpper());//it will give string reference exception

            Console.WriteLine(a.Price);//it gives the default value 0

            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
        }
    }
}
