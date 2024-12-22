using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class PastaCarbonara : Dish
    {
        public PastaCarbonara()
        {
            price = 34;
            name = "Makaron Carbonara";
            waitTime = 20;
            ingredients.Add("jajko", 0.053);
            ingredients.Add("boczek", 0.075);
            ingredients.Add("natkapietruszki", 0.0006);
            ingredients.Add("parmezan", 0.0015);
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
