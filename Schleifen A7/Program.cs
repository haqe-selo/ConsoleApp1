using System;

namespace Schleifen_A7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Bitte geben Sie ein Zahl ein");
            i = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(i--);
                Console.WriteLine();
            }
            while (i >= 0);
        }
    }
}
