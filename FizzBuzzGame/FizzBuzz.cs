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
                
                    return "FizzBuzz";
                

                else if (givenNumber % 5 == 0)
                
                    return "Buzz";
                
                    

                else if (givenNumber % 3 == 0)
                

                    return "Fizz";
                
                else
                
                    return "Twoja liczba to " + givenNumber.ToString();
                
                    
        }

            
        
    }
}
