using System;

namespace Schleife_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Geben Sie bitte den Kennwort ein");
            x = Convert.ToInt32(Console.ReadLine());
           
            while (x != 1234)
            {
                Console.WriteLine("Geben Sie bitte den Kennwort ein");
                x = Convert.ToInt32(Console.ReadLine());
            }
            
        }
    }
}
