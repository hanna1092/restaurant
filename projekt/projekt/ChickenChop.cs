using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace projekt
{
    class ChickenChop : Dish
    {
        public ChickenChop()
        {
            price = 31;
            name = "Kotlet z piersi kurczaka";
            waitTime = 10;
            ingredients.Add("kurczak", 0.15);
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
