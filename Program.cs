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
                fizzBuzz.Game();
                Console.WriteLine("\nJeśli chcesz spróbować jeszcze raz wciśnij dowolny przycisk.\nJeśli chcesz wyjść wpisz 'n'.\n");
                maybeOneMoreTime = Console.ReadLine();
            }
            
            
        }
    }
}
