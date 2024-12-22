using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class SoupCustomerFactory : CustomerFactory
    {
        public override Customer MakeCustomer()
        {
            switch (mode)
            {
                case 1:
                    {
                        dish = new List<Dish>() { new SoupBorscht() };
                        return new Customer(dish, 1, 1, 15, false);
                    }
                case 2:
                    {
                        dish = new List<Dish>() { new SoupChicken(), new SoupBorscht() };
                        return new Customer(dish, 3, 3, 30, false);
                    }
                case 3:
                    {
                        dish = new List<Dish>() { new SoupSour() };
                        return new Customer(dish, 1, 1, 40, false);
                    }
                case 4:
                    {
                        dish = new List<Dish>() { new SoupTomato() };
                        return new Customer(dish, 4, 4, 15, false);
                    }
                case 5:
                    {
                        dish = new List<Dish>() { new SoupChicken(), new SoupSour() };
                        return new Customer(dish, 1, 1, 25, false);
                    }
                default:
                    throw new ArgumentException("Nieprawidlowy tryb");

            }
        }
    }
}
