using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class PorkChop  : Dish
    {
        public PorkChop()
        {
            price = 31;
            name = "Kotlet schabowy";
            waitTime = 10;
            ingredients.Add("schab", 0.15);
            ingredients.Add("maka", 0.005);
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
