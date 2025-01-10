using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endpoint_EightToTen.Services.Mini8
{
    public class Mini8Service : IMini8Service
    {
        public string EightBall (string question)
        {
            Random rng = new Random();
            string[] responses= {"It is certain.","Without a doubt.","Yes, definitely.","You may rely on it.","As I see it, yes.","Most likely.","Outlook good.","Yes.","Signs point to yes.","Absolutely.","Reply hazy, try again.","Ask again later.","Better not tell you now.","Cannot predict now.","Concentrate and ask again","Don't count on it.","My reply is no.","My sources say no.","Outlook not so good.","Very doubtful.","Definitely not."};
        
            return "Your question was: " + question + " \nMy response is: " + responses[rng.Next(responses.Length)];
        }
    }
}