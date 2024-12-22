using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class PierogiCustomerFactory : CustomerFactory
    {
        public override Customer MakeCustomer()
        {
            switch (mode)
            {
                case 1:
                    {
                        dish = new List<Dish>() { new PierogiWithCabbageAndMushrooms() };
                        return new Customer(dish, 4, 4, 15, true);
                    }
                case 2:
                    {
                        dish = new List<Dish>() { new PierogiWithCottageCheese(), new PierogiWithCabbageAndMushrooms() };
                        return new Customer(dish, 5, 4, 30, true);
                    }
                case 3:
                    {
                        dish = new List<Dish>() { new PierogiWithCottageCheese() };
                        return new Customer(dish, 2, 1, 40, false);
                    }
                case 4:
                    {
                        dish = new List<Dish>() { new PierogiWithPotatoAndCottageCheese() };
                        return new Customer(dish, 3, 3, 15, false);
                    }
                case 5:
                    {
                        dish = new List<Dish>() { new PierogiWithPotatoAndCottageCheese(), new PierogiWithCottageCheese() };
                        return new Customer(dish, 3, 5, 25, true);
                    }
                default:
                    throw new ArgumentException("Nieprawidlowy tryb");

            }
        }
    }
}
