using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Coin c1;
            c1 = new Coin();

            Coin c2;

            c2 = new Coin();


            for (int i = 0; i <= 10; i++)
            {
                c2.Flip();

                //c1.face = 2;
                Console.WriteLine(c1.GetFace());
                c1.Flip();
                Console.WriteLine(c1.GetFace());


            }

            Console.WriteLine("Hello World");
        }
    }
}


