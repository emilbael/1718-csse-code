using System;

namespace oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal in: ");
            int aantal=Convert.ToInt32(Console.ReadLine());
            int fibo1 = 0;
            int fibo2 = 1;

            
            Console.WriteLine(fibo1);
            Console.WriteLine(fibo2);

            for (int i = 3; i <=aantal; i++)
            {
                int fibo3 = fibo1 + fibo2;
                fibo1 = fibo2;
                fibo2 = fibo3;
                Console.WriteLine(fibo3);
            }
        }
    }
}
