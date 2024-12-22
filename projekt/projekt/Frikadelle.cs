using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Frikadelle : Dish
    {
        public Frikadelle()
        {
            price = 28;
            name = "Kotlet mielony";
            waitTime = 20;
            ingredients.Add("miesomielone", 0.0625);
            ingredients.Add("cebula", 0.015);
            ingredients.Add("jajko", 0.027);
            ingredients.Add("bulkatarta", 0.008);
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
