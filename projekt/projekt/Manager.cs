using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Manager : Worker
    {
        private Restaurant restaurant;
        private Pantry pantry;
        private Shop shop;
        private Waiter waiter;
        private Chef chef;

        public Manager(Restaurant restaurant, Pantry pantry, Shop shop, Waiter waiter, Chef chef)
        {
            this.restaurant = restaurant;
            this.pantry = pantry;
            this.shop = shop;
            this.waiter = waiter;
            this.chef = chef;
        }
        public Restaurant Restaurant
        {get { return restaurant; }}
        public Pantry Pantry
        { get { return pantry; } }
        public Shop Shop
        { get { return shop; } }
        public Waiter Waiter
        { get { return waiter; } }
        public Chef Chef
        { get { return chef; } }

        public override double Payment()
        {
            return restaurant.Money*0.5;
        }
        public void Pay(double amount)
        {
            restaurant.ChangeBudget(amount);
        }
        public void Buy(string product, double mass)
        {
            pantry.AddPantry(product, mass);
            double price = shop.GetPrice(product, mass);
            restaurant.ChangeBudget(price);
        }
    }
}
