using System;
using System.Collections;
using System.Collections.Generic;

namespace week_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal in van 0 tot 10: ");
           int getal1;
           int teller;
           int product;
           int[] tafel = new int[11];
           List<int> tafel2 = new List<int>();
           Hashtable tafel3 = new Hashtable();
           getal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

        if (getal1 <=10)
        {
            for(teller = 0; teller < 11; teller++)
            {
                product = getal1 * teller;
                Console.WriteLine(getal1.ToString()+ " x " + teller.ToString()+ " = " +product.ToString());
                 tafel[teller] = product;
                 tafel2.Add(product);
                 tafel3.Add("product " + teller, product);
            }
            Console.WriteLine();


        }

        else
        {
            Console.WriteLine("foutief getal");
            Console.WriteLine();
        }
        
            Console.WriteLine("Array");
           foreach (int c in tafel)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("======================================");

            Console.WriteLine("List");
             foreach (int c in tafel2)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("======================================");

            Console.WriteLine("Hashtable");
             foreach (DictionaryEntry entry in tafel3)
            {
                Console.WriteLine(" {0}: {1}", entry.Key, entry.Value);
            }
            Console.WriteLine("======================================");

        } 
    

        }
    }

