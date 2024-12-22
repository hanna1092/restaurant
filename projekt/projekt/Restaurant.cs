using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Restaurant
    {
        private int openHour;
        private int closeHour;
        private double money;
        private int seat;
        private Dictionary<string, int> restaurantMenu;
        private List<Dish> dishes;
        
        public Restaurant(int openHour, int closeHour, double money, int seat)
        {
            this.openHour = openHour;
            this.closeHour = closeHour;
            this.money = money;
            this.seat = seat;
            restaurantMenu = new Dictionary<string, int>();
            CreateDishesList();
            foreach(Dish dish in dishes)
            {
                restaurantMenu.Add(dish.Name, dish.Price);
            }
        }
        public int OpenHour
        {
            get { return openHour; }
        }
        public int CloseHour
        { 
            get { return closeHour; } 
        }
        public double Money
        { 
            get { return money; } 
        }
        public int Seat 
        { 
            get {  return seat; }
        }
        public Dictionary<string, int> RestaurantMenu
        {
            get { return restaurantMenu; }
        }
        private void CreateDishesList()
        {
            dishes = new List<Dish>();
            dishes.Add(new PancakeWithChocolateCream());
            dishes.Add(new PancakeWithCottageCheese());
            dishes.Add(new PancakeWithFruits());
            dishes.Add(new PastaBolognese());
            dishes.Add(new PastaCarbonara());
            dishes.Add(new PierogiWithCabbageAndMushrooms());
            dishes.Add(new PierogiWithCottageCheese());
            dishes.Add(new PierogiWithPotatoAndCottageCheese());
            dishes.Add(new SoupBorscht());
            dishes.Add(new SoupChicken());
            dishes.Add(new SoupSour());
            dishes.Add(new SoupTomato());
            dishes.Add(new ChickenChop());
            dishes.Add(new Frikadelle());
            dishes.Add(new PorkChop());
        }
        public void ChangeBudget(double price)
        {
            money = money - price;
        }
        public void AddBudget(int price)
        {
            money = money + price;
        }
    }
}
