using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class PancakeWithFruits : Dish
    {
        public PancakeWithFruits()
        {
            price = 25;
            name = "Nalesniki z owocami";
            waitTime = 20;
            ingredients.Add("maka", 0.17);
            ingredients.Add("cukier", 0.013);
            ingredients.Add("mleko", 0.025);
            ingredients.Add("jajko", 0.106);
            ingredients.Add("malina", 0.04);
            ingredients.Add("borowka", 0.04);
            ingredients.Add("banan", 0.1);
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
