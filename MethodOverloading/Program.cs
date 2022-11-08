using System;

namespace MethodOverload
{

    class Program
    {

        void display(int a, string b)
        {
            Console.WriteLine("int: " + a);
            Console.WriteLine("string: " + b);
        }

        void display(string b, int a)
        {
            Console.WriteLine("string: " + b);
            Console.WriteLine("int: " + a);
        }
        static void Main(string[] args)
        {

            Program p1 = new Program();
            p1.display(100, "Programming");
            p1.display("Programiz", 400);
            Console.ReadLine();
        }
    }
}