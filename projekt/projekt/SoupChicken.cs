using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class SoupChicken : Dish
    {
        public SoupChicken()
        {
            price = 16;
            name = "Rosol";
            waitTime = 20;
            ingredients.Add("kurczak", 0.5);
            ingredients.Add("marchewka", 0.0375);
            ingredients.Add("cebula", 0.03);
            ingredients.Add("natkapietruszki", 0.005);
        }
        public int Price
        {
            get { return price; }
        }
        public string Name
        {
            get { return name; }
        }
        public Dictionary<string, double> Ingredients
        {
            get { return ingredients; }
        }
    }
}

