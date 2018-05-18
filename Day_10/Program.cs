using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Funkcija1();
            Funkcija2();
        }

        static void Funkcija1()

        {
            string a, b;

            
                Console.WriteLine("Skaitlis a: ");

                a = Console.ReadLine();
                int Ievade1 = Convert.ToInt16(a);

            Console.WriteLine("Skaitlis b: ");

            b = Console.ReadLine();
            int Ievade2 = Convert.ToInt16(b);

            int result = Ievade1 + Ievade2;
          
           //int c = a + b;

                Console.WriteLine(" a + b = " + result);

                Console.ReadLine();
            
        }

        static void Funkcija2()

        {
            string d, e;
   

            Console.WriteLine("Skaitlis a: ");

            d = Console.ReadLine();
            int Ievade3 = Convert.ToInt16(d);

            Console.WriteLine("Skaitlis b: ");

            e = Console.ReadLine();
            int Ievade4 = Convert.ToInt16(e);

            int result2 = Ievade3 - Ievade4;

            Console.WriteLine(" a - b = " + result2);

            Console.ReadLine();

        }
    
    }
    
}
