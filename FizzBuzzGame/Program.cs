using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string maybeOneMoreTime = null;
            var fizzBuzz = new FizzBuzz();
            while(maybeOneMoreTime != "n")
            {
                Console.WriteLine("\nWitaj, w grze FizzBuzz. Podaj mi proszę liczbę całkowitą, a ja sprawdzę jej podzielność.\nJeżeli będzie podzielna przez 3 wyświetlę komunikat 'fizz', jeżeli będzie podzielna przez 5 wyświetlę komunikat 'Buzz', natomiast jeśli będzie jednocześnie podzielna przez 3 i 5 wyświetlę komunikat 'FizzBuzz'.\nJeżeli nie będzie podzielna przez żadne z powyższych, zwrócę Ci liczbę. \n");

                if (!int.TryParse(Console.ReadLine(), out int givenNumber))
                {
                    Console.WriteLine("\nPodałeś błędne dane, podaj liczbę całkowitą!\n");
                    continue;
                }
                else
                {
                    Console.WriteLine("\n" + fizzBuzz.Game(givenNumber) + "\n");
                    Console.WriteLine("\nJeśli chcesz spróbować jeszcze raz wciśnij dowolny przycisk.\nJeśli chcesz wyjść wpisz 'n'.\n");
                    maybeOneMoreTime = Console.ReadLine();
                }

            }
            
            
        }
    }
}
