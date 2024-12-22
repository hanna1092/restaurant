using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class PancakeWithChocolateCream : Dish
    {
        public PancakeWithChocolateCream()
        {
            price = 25;
            name = "Nalesniki z Nutella";
            waitTime = 10;
            ingredients.Add("maka", 0.17);
            ingredients.Add("cukier", 0.013);
            ingredients.Add("mleko", 0.025);
            ingredients.Add("jajko", 0.106);
            ingredients.Add("nutella", 0.06);
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
