using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your name");
            String name = System.Console.ReadLine();
            System.Console.WriteLine("Good Morning  " + name);
            int a = 5; int b = 10;
            Console.WriteLine("{0}+{1}={2}", a, b, a + b); //5+10=15
            Console.WriteLine("{2}={0}+{1}", a, b, a + b); //15=5+10
            double balabce = 12345.678912345;
            double balance1 = 1234567892323;

            Console.WriteLine("${0:0.00}", balabce);
            Console.WriteLine("${0,000}", balance1);
            Console.WriteLine("${0,000.00}", balance1);

            double x = 123;
            double y = 33.334;
            Console.WriteLine("{0:0.0}  {1:0.0}", x, y);
            Console.WriteLine("{0:0.0}  {1:0.0}", x, y);
            Console.WriteLine("{0:#.#}  {1:#.#}", x, y);//123   33.3

            Console.WriteLine("0.00000}", x); //00123
            Console.WriteLine("0.00}", x);  //123
            Console.WriteLine("0.###00}", x); //123


        }


    }
}
