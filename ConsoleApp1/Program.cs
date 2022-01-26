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

            for(int a =i; a>=-i;a--)
            {
                Console.WriteLine(a);
            }
        }
   }
}   
