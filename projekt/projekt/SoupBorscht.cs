using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class SoupBorscht : Dish
    {
        public ChickenChop dish;

        public void xd()
        {
            Console.WriteLine(dish.Name);
        }
        public SoupBorscht()
        {
            price = 14;
            name = "Barszcz czerwony";
            waitTime = 20;
            ingredients.Add("burak", 0.5);
            ingredients.Add("bulion", 0.625);
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

