using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class PastaBolognese : Dish
    {
        public PastaBolognese()
        {
            price = 30;
            name = "Makaron Bolognese";
            waitTime = 30;
            ingredients.Add("cebula", 0.015);
            ingredients.Add("marchewka", 0.037);
            ingredients.Add("miesomielone", 0.0625);
            ingredients.Add("koncentratpomidorowy", 0.0125);
            ingredients.Add("makaron", 0.075);
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
