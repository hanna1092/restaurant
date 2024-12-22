using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class PierogiWithCabbageAndMushrooms  : Dish
    {
        public PierogiWithCabbageAndMushrooms()
        {
            price = 24;
            name = "Pierogi z kapusta i grzybami";
            waitTime = 20;
            ingredients.Add("maka", 0.09);
            ingredients.Add("maslo", 0.009);
            ingredients.Add("grzyby", 0.0125);
            ingredients.Add("kapusta", 0.125);
            ingredients.Add("marchewka", 0.009);
            ingredients.Add("cebula", 0.045);
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
