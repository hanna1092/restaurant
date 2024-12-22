using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class SoupTomato : Dish
    {
        public SoupTomato()
        {
            price = 17;
            name = "Pomidorowa";
            waitTime = 10;
            ingredients.Add("kurczak", 0.085);
            ingredients.Add("marchewka", 0.019);
            ingredients.Add("cebula", 0.03);
            ingredients.Add("koncentratpomidorowy", 0.05);
            ingredients.Add("smietana", 0.055);
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
