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

            int sum = 0;
            for(int a=0;a<=i;a++)
            {
                sum = sum+a ;
               
            }
            Console.WriteLine(sum);
        }
    }
}
