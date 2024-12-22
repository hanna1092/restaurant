using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public abstract class Dish
    {
        protected string name;
        protected int price;
        protected Dictionary<string, double> ingredients = new Dictionary<string, double>();
        protected int waitTime;
        public int Price
        {
            get { return price; }
        }
        public string Name
        {
            get { return name; }
        }
        public int WaitTime
        { get { return waitTime; } }
        public Dictionary<string, double> Ingredients
        {
            get { return ingredients; }
        }
    }
}
