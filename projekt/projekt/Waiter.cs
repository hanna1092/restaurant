using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Waiter : Worker
    {
        //private Dish dish;
        private Restaurant restaurant;
        //private Customer customer;
        private Day day;
        private int payment;
        private int grade;
        private int customersCount;
        private List<Customer> customers;
        private Pantry pantry;
        
        public Waiter(Restaurant restaurant, Day day, int payment, Pantry pantry)
        {
            this.restaurant = restaurant;
            this.day = day;
            this.payment = payment;
            this.pantry = pantry;
            grade= 0;
            customersCount = 0;
            customers = new List<Customer>();
        }
        public int Grade
        { get { return grade; } }
        public int CustomersCount
        { get { return customersCount; } }
        public override double Payment()
        {
            double averageGrade = grade / customersCount;
            if(averageGrade >=4)
            {
                return payment + 40;
            }
            else if(averageGrade >=3)
            {
                return payment;
            }
            else
            {
                return payment - 50;
            }
        }
        public bool CheckSeat(Customer customer)
        {
            for (int i = customers.Count - 1; i >= 0; i--)
            {
                Customer custom = customers[i];
                if (day.Hour > custom.OutHour || day.Weekday!=custom.OutDay)
                {
                    customers.RemoveAt(i);
                }
            }

            if (customers.Count < restaurant.Seat)
            {
                customers.Add(customer);
                return true;
            }
            return false;
        }
        public void RemoveCustomer(Customer customer)
        {
            customers.Remove(customer);
        }
        public bool CheckHour()
        {
            if(day.Hour > restaurant.OpenHour && day.Hour < restaurant.CloseHour)
            {
                return true;
            }
            return false;
        }
        public List<Dish> GetOrder(Customer customer, string order)
        {
            string help = order;
            Dish newDish = null;
            switch (help)
            {
                    case "Nalesniki z Nutella":
                        newDish = new PancakeWithChocolateCream();
                        break;
                    case "Nalesniki z serem":
                        newDish = new PancakeWithCottageCheese();
                        break;
                    case "Nalesniki z owocami":
                        newDish = new PancakeWithFruits();
                        break;
                    case "Pierogi z kapusta i grzybami":
                        newDish = new PierogiWithCabbageAndMushrooms();
                        break;
                    case "Pierogi ruskie":
                        newDish = new PierogiWithPotatoAndCottageCheese();
                        break;
                    case "Pierogi z serem":
                        newDish = new PierogiWithCottageCheese();
                        break;
                    case "Makaron Bolognese":
                        newDish = new PastaBolognese();
                        break;
                    case "Makaron Carbonara":
                        newDish = new PastaCarbonara();
                        break;
                    case "Barszcz czerwony":
                        newDish = new SoupBorscht();
                        break;
                    case "Rosol":
                        newDish = new SoupChicken();
                        break;
                    case "Zurek":
                        newDish = new SoupSour();
                        break;
                    case "Pomidorowa":
                        newDish = new SoupTomato();
                        break;
                    case "Kotlet z piersi kurczaka":
                        newDish = new ChickenChop();
                        break;
                    case "Kotlet mielony":
                        newDish = new Frikadelle();
                        break;
                    case "Kotlet schabowy":
                        newDish = new PorkChop();
                        break;
                    default:
                        break;
            }
            if(newDish!= null)
            {
                if(customer.DoubleDish)
                {
                    newDish = new DoubleDish(newDish);
                }
            }
            customer.Order.Add(newDish);
            return customer.Order;       
        }
        
        public void SetGrade(int clientGrade)
        {
            grade = grade + clientGrade;
            customersCount++;
        }
        public void AddMoney(Customer customer)
        {
            int xd = 0;
            foreach(Dish dish in customer.Order)
            {
                xd = xd + dish.Price;
                restaurant.AddBudget(dish.Price);
            }
            //Console.WriteLine(xd);
        }
        public bool CheckIngredients(Customer customer)
        {
            foreach(Dish dish in customer.Order)
            {
               foreach(KeyValuePair<string, double> kvp in dish.Ingredients) 
               {
                    pantry.Stores.TryGetValue(kvp.Key, out double value);   
                    if(value < kvp.Value)
                    {
                        return false;
                    }
               }
            }
            return true;
        }
       public void RemovePantry(Customer customer)
        {
            foreach(Dish dish in customer.Order)
            {
                foreach(KeyValuePair<string, double> kvp in dish.Ingredients)
                {
                    pantry.RemovePantry(kvp.Key,kvp.Value);
                }
            }
        }
        public int WaitTime(Customer customer)
        {
            int time = 0;
            foreach(Dish dish in customer.Order)
            {
                time = time + dish.WaitTime;
            }
            return time;
        }
        public void Reset()
        {
            grade = 0;
            customersCount = 0;
        }
    }
}
