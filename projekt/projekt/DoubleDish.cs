using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class DoubleDish : Dish
    {
        protected Dish _decoratedDish;
        public DoubleDish(Dish decoratedDish)
        {
            price = decoratedDish.Price * 2;
            waitTime = decoratedDish.WaitTime;
            name = decoratedDish.Name;
            ingredients = new Dictionary<string, double>();
            foreach (var item in decoratedDish.Ingredients)
            {
                ingredients.Add(item.Key, item.Value*2);
            }
        }

        

        
    }
}
