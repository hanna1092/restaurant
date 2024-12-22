using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class MeatCustomerFactory : CustomerFactory
    {
        public override Customer MakeCustomer()
        {
            switch (mode)
            {
                case 1:
                    {
                        dish = new List<Dish>() { new ChickenChop() };
                        return new Customer(dish, 4, 4, 15, true);
                    }
                case 2:
                    {
                        dish = new List<Dish>() { new Frikadelle(), new PastaBolognese() };
                        return new Customer(dish, 5, 4, 30, false);
                    }
                case 3:
                    {
                        dish = new List<Dish>() { new PastaCarbonara() };
                        return new Customer(dish, 2, 1, 40, true);
                    }
                case 4:
                    {
                        dish = new List<Dish>() { new PorkChop() };
                        return new Customer(dish, 3, 3, 15, true);
                    }
                case 5:
                    {
                        dish = new List<Dish>() { new PastaBolognese(), new PastaCarbonara() };
                        return new Customer(dish, 3, 5, 25, false);
                    }
                default:
                    throw new ArgumentException("Nieprawidlowy tryb");

            }
        }
    }
}
