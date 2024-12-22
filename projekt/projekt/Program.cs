using projekt;
using System;
using System.Collections.Generic;
using System.Threading;

namespace zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {

            void Waiter(Customer customer0, Waiter waiter, Restaurant restaurant, Day day, Comment comment, Chef chef, Pantry pantry)
            {
                string help;
                string help2;
                if (waiter.CheckSeat(customer0))
                {
                    Console.WriteLine("Zapraszamy do restauracji");
                    Console.WriteLine("Oto menu: ");
                    foreach (KeyValuePair<string, int> kvp in restaurant.RestaurantMenu)
                    {
                        Console.WriteLine($"{kvp.Key,-35} {kvp.Value}");
                    }
                    Console.WriteLine("Co zamawiasz?");
                    do
                    {
                        //if (!waiter.CheckIngredients(customer0))
                        //{ Console.WriteLine("Dania niedostepne, zloz zamowienie ponownie"); }
                        //customer0.Order.Clear();
                        bool cont = true;
                        while (cont)
                        {
                            help = Console.ReadLine();
                            Console.WriteLine("Czy powiekszony?");
                            help2 = Console.ReadLine();
                            if (help2 == "tak")
                            {
                                customer0.ChangeDoubleDish(true);
                            }
                            waiter.GetOrder(customer0, help);
                            Console.WriteLine("Czy cos jeszcze? tak/nie");
                            help = Console.ReadLine();
                            customer0.ChangeDoubleDish(false);
                            if (help == "nie")
                            {
                                cont = false;
                            }
                        }
                    }

                    while (!waiter.CheckIngredients(customer0));

                    waiter.RemovePantry(customer0);
                    customer0.SetOutHour(day);
                    customer0.SetOutDay(day);
                    Console.WriteLine("Czas oczekiwania wynosi: " + waiter.WaitTime(customer0));
                    Thread.Sleep(waiter.WaitTime(customer0) * 100);
                    waiter.AddMoney(customer0);
                    Console.WriteLine(comment.GetComment());

                    Console.WriteLine("Ocen danie (calkowite od 1 do 5)");
                    int grade1 = Convert.ToInt32(Console.ReadLine());
                    customer0.ChangeDishGrade(grade1);
                    Console.WriteLine("Ocen obsluge (calkowite od 1 do 5)");
                    int grade2 = Convert.ToInt32(Console.ReadLine());
                    customer0.ChangeServiceGrade(grade2);
                    waiter.SetGrade(customer0.ServiceGrade);
                    chef.SetGrade(customer0.DishGrade);
                }
                
            
                else
                { Console.WriteLine("zapraszamy pozniej"); }

            }
            void Manager(Restaurant restaurant, Pantry pantry, Shop shop, Manager manager, Dictionary<string,double> previousPantry)
            {
                Console.WriteLine("Pieniadze: " + restaurant.Money);
                Console.WriteLine("Stan spizarni prezentuje sie nastepujaco");
                Console.WriteLine($"{"Nazwa produktu",-25}{"Stan obecny",-20}{"Stan rano",-20}{"Cena za kg",-15}");
                foreach (var item in pantry.Stores)
                {
                    previousPantry.TryGetValue(item.Key, out double value);
                    shop.Assortment.TryGetValue(item.Key, out var assortmentValue);
                    Console.WriteLine($"{item.Key,-25} {item.Value,-20} {value, -20} {assortmentValue,-15}");
                }
                
                Console.WriteLine("Co kupujesz i w jakiej ilosci (ile kilogramow)");
                bool xd = true;
                while (xd)
                {
                    string input = Console.ReadLine();
                    string h;
                    double mass;
                    string[] values = input.Split(' ');
                    double.TryParse(values[1], out mass);
                    h = values[0];
                    manager.Buy(h, mass);
                    Console.WriteLine("Czy cos jeszcze?");
                    h = Console.ReadLine();
                    if (h == "nie")
                    {
                        xd = false;
                    }

                }
            }
            void Customer(Day day, List<CustomerFactory> customerFactory, Waiter waiter, Chef chef)
            {
                
                        Random rand = new Random();
                        float random = rand.Next(10, 20);
                        day.ChangeHour(random / 60);
                        CustomerFactory c = customerFactory[rand.Next(0, customerFactory.Count())];
                        c.SetProductionMode(rand.Next(1, 5));
                        Customer customer = c.MakeCustomer();
                {
                    if (waiter.CheckHour() && waiter.CheckSeat(customer))
                    {
                        if (waiter.CheckIngredients(customer))
                        {

                            waiter.RemovePantry(customer);
                            customer.SetOutHour(day);
                            customer.SetOutDay(day);
                            waiter.AddMoney(customer);
                            waiter.SetGrade(customer.ServiceGrade);
                            chef.SetGrade(customer.DishGrade);
                        }
                        else
                        {
                            //Console.WriteLine("brak produktow");
                            waiter.RemoveCustomer(customer);
                        }
                    }
                }

                    
                
            }
                Comment comment = new Comment();
                VegetarianCustomerFactory vege = new VegetarianCustomerFactory();
                MeatCustomerFactory meat = new MeatCustomerFactory();
                PierogiCustomerFactory pierogi = new PierogiCustomerFactory();
                SoupCustomerFactory soup = new SoupCustomerFactory();
                List<CustomerFactory> customerFactory = new List<CustomerFactory>() { vege, meat, pierogi, soup };
                Restaurant restaurant = new Restaurant(8, 20, 20300, 20);
                Pantry pantry = new Pantry();
                Shop shop = new Shop();
                Day day = new Day(10, "sroda");

                Waiter waiter = new Waiter(restaurant, day, 500, pantry);
                Chef chef = new Chef(500);
                Manager manager = new Manager(restaurant, pantry, shop, waiter, chef);
                List<Dish> list = new List<Dish>();

                string help;
                Random rand = new Random();
                
                
                
                for (int k = 0; k < 4; k++)
                {
                    Customer customer0 = new Customer(list, 0, 0, 20, false);
                    for(int i =0; i<7; i++) 
                    {
                    Console.WriteLine("Co chcesz robic ???");
                    Console.WriteLine("1. Zamow zamowienie z restauracji");
                    Console.WriteLine("2. Kup produkty do restauracji");
                    Console.WriteLine("3. NIC");
                    //Console.WriteLine(day.Weekday);
                    help = Console.ReadLine();
                    if (help == "1")
                    {
                        Waiter(customer0, waiter, restaurant, day, comment, chef, pantry);
                        string weekday = day.Weekday;
                        while (weekday == day.Weekday)
                        {
                            Customer(day, customerFactory, waiter, chef);
                        }
                    }
                    else if (help == "2")
                    {
                        Dictionary<string, double> previousPantry = new Dictionary<string, double>(pantry.GetPantry());
                        string weekday = day.Weekday;
                        while (weekday == day.Weekday)
                        {
                            Customer(day, customerFactory, waiter, chef);
                        }
                        Manager(restaurant, pantry, shop, manager, previousPantry);
                        
                    }
                    else if (help == "3")
                    {
                        string weekday = day.Weekday;
                        while (weekday == day.Weekday)
                        {
                            Customer(day, customerFactory, waiter, chef);
                        }
 
                    }
                    else
                    {
                        Console.WriteLine("Nie wybrano poprawnie");
                    }
                    }
            
                   

                    //Console.WriteLine(cus);


                    Console.WriteLine("Ocena kelnera: " + waiter.Grade / waiter.CustomersCount);
                    Console.WriteLine("Ocena kucharza: " + (double)chef.Grade / chef.CustomersCount);
                    Console.WriteLine("Zarobek kelnera: " + waiter.Payment());
                    Console.WriteLine("Zarobek kucharza: " + (double)chef.Payment());
                    waiter.AddAllMoney(waiter.Payment());
                    chef.AddAllMoney(chef.Payment());
                    manager.Pay(chef.Payment());
                    manager.Pay(waiter.Payment());
                    Console.WriteLine("Zarobek kierownika: " + manager.Payment());
                    manager.Pay(manager.Payment());
                    manager.AddAllMoney(manager.Payment());
                    waiter.Reset();
                    chef.Reset();
                }
                Console.WriteLine("miesieczna wyplata kelnera: " + waiter.AllMoney);
                Console.WriteLine("miesieczna wyplata kucharza: " + chef.AllMoney);
                Console.WriteLine("miesieczna wyplata kierownika: " + manager.AllMoney);
                Console.WriteLine("Stan budzetu po miesiacu prowadzenia restauracji: " + restaurant.Money);

            }
        }
    }


