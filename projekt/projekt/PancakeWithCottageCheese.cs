using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class PancakeWithCottageCheese : Dish
    {
        public PancakeWithCottageCheese()
        {
            price = 25;
            name = "Nalesniki z serem";
            waitTime = 10;
            ingredients.Add("maka", 0.17);
            ingredients.Add("cukier", 0.013);
            ingredients.Add("mleko", 0.025);
            ingredients.Add("jajko", 0.106);
            ingredients.Add("twarog", 0.45);
            ingredients.Add("cukierpuder", 0.024);
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
