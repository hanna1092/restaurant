﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class PierogiWithCottageCheese : Dish
    {
        public PierogiWithCottageCheese()
        {
            price = 24;
            name = "Pierogi z serem";
            waitTime = 20;
            ingredients.Add("maka", 0.09);
            ingredients.Add("maslo", 0.009);
            ingredients.Add("twarog", 0.083);
            ingredients.Add("cukier", 0.0067);
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
