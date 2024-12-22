using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Pantry
    {
        private Dictionary<string, double> stores; 

        public Pantry()
        {
            stores = new Dictionary<string, double>();
            stores.Add("kurczak", 20);
            stores.Add("maka", 50);
            stores.Add("jajko", 20);
            stores.Add("bulkatarta", 10);
            stores.Add("miesomielone", 25);
            stores.Add("cebula", 20);
            stores.Add("cukier", 5);
            stores.Add("mleko", 12);
            stores.Add("nutella", 10);
            stores.Add("twarog", 50);
            stores.Add("cukierpuder", 1);
            stores.Add("malina", 4);
            stores.Add("borowka", 4);
            stores.Add("banan", 4);
            stores.Add("marchewka", 5);
            stores.Add("koncentratpomidorowy", 10);
            stores.Add("makaron", 10);
            stores.Add("boczek", 10);
            stores.Add("natkapietruszki", 1);
            stores.Add("parmezan", 2);
            stores.Add("maslo", 10);
            stores.Add("grzyby", 15);
            stores.Add("kapusta", 20);
            stores.Add("ziemniak", 20);
            stores.Add("schab", 25);
            stores.Add("burak", 20);
            stores.Add("kielbasa", 5);
            stores.Add("zur", 10);
            stores.Add("smietana", 15);
            stores.Add("bulion", 50);
        }
        public Dictionary<string, double> Stores { get { return stores; } } 
        public void AddPantry(string product,  double value)
        {
            stores[product] = stores[product] + value;
        }
        public void RemovePantry(string product, double value) 
        {
            stores[product] = stores[product] - value;
        }
        public Dictionary<string, double> GetPantry() 
        { 
            return stores;
        }
    }
}
