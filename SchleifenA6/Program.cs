using System;

namespace SchleifenA6
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int a;
            

            do
            {
                Console.WriteLine("Menü");
                a = Convert.ToInt32(Console.ReadLine());
            }
            while (a!=0);
        }
    }
}
