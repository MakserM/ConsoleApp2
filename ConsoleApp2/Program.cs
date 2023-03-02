using ClassLibraryKalkulator;
using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz kalkulator:");

            Console.WriteLine("KALKULATOR PROSTY = 1");

            Console.WriteLine("KALKULATOR ZAWANSOWANY = 2");

            var Kl = int.Parse(Console.ReadLine());

            if (Kl == 1)
            {
                Console.WriteLine("INSTRUKCJA: \n + dodawanie \n - odejmowanie \n * mnożenie \n / dzielenie \n");
                ProstyKalkulator.START();
            }
            else if (Kl == 2)
            {
                Console.WriteLine("INSTRUKCJA: \n + dodawanie \n - odejmowanie \n * mnożenie \n / dzielenie \n ^ potęgowanie \n 'W' wczytanie poprzedniego wyniku \n = wypisanie wyniku \n");
                ZawansowanyKalkulator.START();
            }
            else
            {
                Console.WriteLine("Wybrałeś złą operację!");
            }

        }
    }
}
