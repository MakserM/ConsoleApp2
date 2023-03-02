using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryKalkulator
{
    public class ZawansowanyKalkulator
    {
        public static void START()
        {
            Console.WriteLine("Witaj w aplikacji KALKULATORZE ZAWANSOWANYM!");

            Console.WriteLine("Podaj proszę liczbę:");

            var number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Jaką operację chcesz wykonać? Możliwe operacje to: ' + ', ' - ', ' * ', ' / ', ' ^ '.");

            while (true)
            {

                var operation = Console.ReadLine();

                if(operation == "="){

                    break;

                }

                if(operation == "W")
                {
                    number1 = int.Parse(File.ReadAllText("Zapis.txt"));

                    Console.WriteLine("wykonać następną operacje (' + ', ' - ', ' * ', ' / ', ' ^ ', ' W '.) czy zakończyć (' = ') ?");

                    continue;
                }

                Console.WriteLine("Podaj proszę kolejną liczbę:");

                var number2 = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    case "+":
                        number1 = number1 + number2;
                        break;
                    case "-":
                        number1 = number1 - number2;
                        break;
                    case "*":
                        number1 = number1 * number2;
                        break;
                    case "/":
                        number1 = number1 / number2;
                        break;
                    case "^":
                        number1 = (int)Math.Pow(number1, number2);
                        break;
                    default:
                        throw new Exception("Wybrałeś złą operację!");
                }

                Console.WriteLine("wykonać następną operacje (' + ', ' - ', ' * ', ' / ', ' ^ ', ' W '.) czy zakończyć (' = ') ?");
            }

            Console.WriteLine(number1);

            File.WriteAllText("Zapis.txt", number1.ToString());
            Console.WriteLine("Wynik zapisany do pliku \n");
        }
    }
}
