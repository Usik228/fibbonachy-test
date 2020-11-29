using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input length");
            GetNthFibonacci_Ite(Convert.ToInt16(Console.ReadLine()));
            Console.ReadLine();
        }
        public static void GetNthFibonacci_Ite(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
    }
}