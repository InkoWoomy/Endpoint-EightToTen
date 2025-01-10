using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endpoint_EightToTen.Services.Mini9A
{
    public class Mini9AService : IMini9AService
    {
        
        public string GuessItEasy (string input)
        {
            Random rng = new Random();
            int randNum = rng.Next(1, 10);
            int parsedInput;
            if (int.TryParse(input, out parsedInput))
            {
                if (parsedInput > 10 || parsedInput < 1)
                {
                    return "Your guess needs to be between 1 and 10. Please try again.";
                }
                 else if (parsedInput < randNum)
                {
                    return "Your guess is less than the actual number by " + (randNum - parsedInput) + ".";
                } else if (parsedInput > randNum)
                {
                    return "Your guess is greater than the actual number by " + (parsedInput - randNum)  + ".";
                } else {
                    return "Wow! You got it right on the mark!";
                }
            }
            return "That is not a number";
        }
    }
}