using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Shop
    {
        private Dictionary<string, int> assortment;

        public Shop()
        {
            assortment = new Dictionary<string, int>();
            assortment.Add("kurczak", 10);
            assortment.Add("maka", 4);
            assortment.Add("jajko", 50);
            assortment.Add("bulkatarta", 6);
            assortment.Add("miesomielone", 25);
            assortment.Add("cebula", 3);
            assortment.Add("cukier", 5);
            assortment.Add("mleko", 4);
            assortment.Add("nutella", 10);
            assortment.Add("twarog", 23);
            assortment.Add("cukierpuder", 17);
            assortment.Add("malina", 4);
            assortment.Add("borowka", 13);
            assortment.Add("banan", 7);
            assortment.Add("marchewka", 5);
            assortment.Add("koncentratpomidorowy", 19);
            assortment.Add("makaron", 10);
            assortment.Add("boczek", 45);
            assortment.Add("natkapietruszki", 14);
            assortment.Add("parmezan", 100);
            assortment.Add("maslo", 27);
            assortment.Add("grzyby", 40);
            assortment.Add("kapusta", 3);
            assortment.Add("ziemniak", 3);
            assortment.Add("schab", 25);
            assortment.Add("burak", 3);
            assortment.Add("kielbasa", 65);
            assortment.Add("zur", 11);
            assortment.Add("smietana", 15);
            assortment.Add("bulion", 80);
        }
        public Dictionary<string, int> Assortment 
        { get { return assortment; } }
        public double GetPrice(string product, double volume)
        {
            int price = assortment[product];
            return price * volume;
        }
    }
}
