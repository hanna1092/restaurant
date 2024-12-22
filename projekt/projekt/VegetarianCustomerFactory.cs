using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class VegetarianCustomerFactory : CustomerFactory
    {
        public override Customer MakeCustomer()
        {
            switch(mode)
            {
                case 1:
                {
                    dish = new List<Dish>() { new PancakeWithChocolateCream() };
                    return new Customer(dish, 4, 1, 15, true);
                }
                case 2:
                {
                    dish = new List<Dish>() { new PancakeWithCottageCheese(), new PierogiWithCabbageAndMushrooms() };
                    return new Customer(dish, 1, 1, 30, true);
                }
                case 3:
                {
                    dish = new List<Dish>() { new PierogiWithCottageCheese() };
                    return new Customer(dish, 1, 4, 40, true);
                }
                case 4:
                {
                   dish = new List<Dish>() { new PierogiWithPotatoAndCottageCheese() };
                   return new Customer(dish, 1, 3, 15, true);
                }
                case 5:
                {
                    dish = new List<Dish>() { new PancakeWithFruits(), new PancakeWithChocolateCream() };
                    return new Customer(dish, 3, 5, 25, true);
                }
                default:
                    throw new ArgumentException("Nieprawidlowy tryb");
                   
            }
        }
    }
}
