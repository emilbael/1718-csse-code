using System;

namespace Opdrachtweek4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Geef een getal in tot en met 100: ");
           int input = Convert.ToInt32(Console.ReadLine());
           for(var a = 0; a <= input ;a++)
           {
               int delers = 0;
                for (int i = 2; i <= a; i++)
                if (a % i == 0)                        
                delers++;

                if (a != 1 && delers == 1)                 
                Console.WriteLine(a + " is een priemgetal.");
                else
                Console.WriteLine(a + " is geen priemgetal.");
               
           }

            
        }
    }
}
