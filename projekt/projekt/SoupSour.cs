using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class SoupSour : Dish
    {
        public SoupSour()
        {
            price = 18;
            name = "Zurek";
            waitTime = 20;
            ingredients.Add("bulion", 0.375);
            ingredients.Add("kielbasa", 0.125);
            ingredients.Add("zur", 0.125);
            ingredients.Add("cebula", 0.03);
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

