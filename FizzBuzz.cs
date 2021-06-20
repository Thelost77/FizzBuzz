using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class FizzBuzz
    {
        public string Game()
        {
            var numberToCheck = 0;

            Console.WriteLine("\nWitaj, w grze FizzBuzz. Podaj mi proszę liczbę całkowitą, a ja sprawdzę jej podzielność.\nJeżeli będzie podzielna przez 3 wyświetlę komunikat 'fizz', jeżeli będzie podzielna przez 5 wyświetlę komunikat 'Buzz', natomiast jeśli będzie jednocześnie podzielna przez 3 i 5 wyświetlę komunikat 'FizzBuzz'.\nJeżeli nie będzie podzielna przez żadne z powyższych, zwrócę Ci liczbę. \n");

            while(true)
            {
                if (!int.TryParse(Console.ReadLine(), out int givenNumber))
                {
                    Console.WriteLine("\nPodałeś błędne dane, podaj liczbę całkowitą!\n");
                    continue;
                }
                else
                numberToCheck = givenNumber;
                if (numberToCheck % 3 == 0 && numberToCheck % 5 != 0)
                {
                    Console.WriteLine("\nFizz\n");
                    return "Fizz";
                }

                else if (numberToCheck % 3 != 0 && numberToCheck % 5 == 0)
                {
                    Console.WriteLine("\nBuzz\n");
                    return "Buzz";
                }
                    

                else if (numberToCheck % 3 == 0 && numberToCheck % 5 == 0)
                {
                    Console.WriteLine("\nFizzBuzz\n");
                    return "FizzBuzz";
                }

                else
                {
                    Console.WriteLine("\nTwoja liczba to : " + numberToCheck.ToString() + "\n");
                    return numberToCheck.ToString();
                }
                    
            }

            
        }
    }
}
