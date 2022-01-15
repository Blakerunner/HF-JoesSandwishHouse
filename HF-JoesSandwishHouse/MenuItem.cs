using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_JoesSandwishHouse
{
    internal class MenuItem
    {
        public static Random Randomizer = new Random();
        public string[] Protiens = { "Roast beef", "Salami", "Ham", "Tofu", "Vegan Chicken", "Turkey" };
        public string[] Condiments = { "mustard", "mayo", "relish", "frensh dressing", "hot sauce" };
        public string[] Breads = { "rye", "white", "wheat", "gluten-free" };
        public string Description;
        public string Price;

        public void Generate()
        {
            string randomProtein = Protiens[Randomizer.Next(Protiens.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            Description = $"{randomProtein} with {randomCondiment} on {randomBread}";

            decimal dollar = Randomizer.Next(2, 15);
            decimal cents = Randomizer.Next(100);
            decimal price = dollar + (cents * .01M);
            Price = price.ToString("c");
        }
    }
}
