using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Bitte geben Sie ein Zahl ein");
            i = Convert.ToInt32(Console.ReadLine());
            //double e = i * 2;
            //Console.WriteLine(i - e);
            //double b = i - e;

            //while (b >= i)
            //{
            //    Console.WriteLine(b++);
            //}
            for(int a =i; a>=-i;a--)
            {
                Console.WriteLine(a);
            }
        }
   }
}   
