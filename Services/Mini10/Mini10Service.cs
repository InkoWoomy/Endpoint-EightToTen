using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endpoint_EightToTen.Services.Mini10
{
    public class Mini10Service : IMini10Service
    {
        public string ResturauntPicker (string input)
        {


            string[] optionPizza = {"Pizza Hut","Little Ceasers","Papa Murphy's","Papa John's","Mountain Mike's","Domino's Pizza","DiGorno","Round Table Pizza","Blaze Pizza","Uno Pizzeria & Grill"};        
            string[] optionFastFood = {"Burger King", "McDonalds", "Wendy's", "Subway", "Jack in the Box", "Taco Bell", "KFC", "Dairy Queen", "Chick-Fil-A", "Popeyes"};
            string[] optionChinese = {"China Palace", "Sun's Garden",  "Good Friends", "Sun Wong Kee", "Sherman Chinese Buffet", "Far East Restauraunt", "China Wok Express", "Dave Wong's Restauraunt and Deli", "Golden Bowl", "Forum Dynasty"};
            Random rng = new Random();

            input = input.ToLower();
            if (input == "pizza")
            {
                return "Today, why don't you eat at: " + optionPizza[rng.Next(optionPizza.Length)] + "?";
            }
            if (input == "fastfood")
            {
                return "Today, why don't you eat at: " + optionPizza[rng.Next(optionFastFood.Length)] + "?";
            }
            if (input == "chinese")
            {
                return "Today, why don't you eat at: " + optionPizza[rng.Next(optionChinese.Length)] + "?";
            }
            return "I don't think I can help with that-";

        }
    }
}