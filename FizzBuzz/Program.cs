using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            
            while (true)
            {
                var liczba = GetLiczba();

                if (liczba % 3 == 0)
                {
                    Console.WriteLine("Fizz");

                }

                else if (liczba % 5 == 0)
                {

                    Console.WriteLine("Buzz");
                }
                else

                    //FizzBuzz.Info();
                   Console.WriteLine("FizzBuzzy");
                   Console.WriteLine("Podaj następną liczbę. Jeżeli chcesz wyjść z aplikacji wpisz 't'.");
                
            }
           
        }

        private static int GetLiczba()
        {

            while (true)
            {
                var val = Console.ReadLine();
                if (val.ToUpper() == "T")
                    Environment.Exit(0);



                if (!int.TryParse(val, out int liczba))

                {
                    Console.WriteLine("Podałeś nie prawidłowe dane. Spróbój ponownie.");
                    continue;
                }
                return liczba;

            }
        }
    }
}

