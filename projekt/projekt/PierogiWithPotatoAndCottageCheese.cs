using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class PierogiWithPotatoAndCottageCheese : Dish
    {
        public PierogiWithPotatoAndCottageCheese()
        {
            price = 24;
            name = "Pierogi ruskie";
            waitTime = 20;
            ingredients.Add("maka", 0.09);
            ingredients.Add("maslo", 0.009);
            ingredients.Add("twarog", 0.071);
            ingredients.Add("ziemniak", 0.071);
            ingredients.Add("cebula", 0.017);
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

