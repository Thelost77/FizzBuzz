using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class FizzBuzz
    {
        public string Game(int givenNumber)
        {

                if (givenNumber % 3 == 0 && givenNumber % 5 == 0)
                {
                    Console.WriteLine("\nFizzBuzz\n");
                    return "FizzBuzz";
                }

                else if (givenNumber % 5 == 0)
                {
                    Console.WriteLine("\nBuzz\n");
                    return "Buzz";
                }
                    

                else if (givenNumber % 3 == 0)
                {
                    Console.WriteLine("\nFizz\n");
                    return "Fizz";
                }

                else
                {
                    Console.WriteLine("\nTwoja liczba to : " + givenNumber.ToString() + "\n");
                    return givenNumber.ToString();
                }
                    
        }

            
        
    }
}
