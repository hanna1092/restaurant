using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Customer
    {
        private List<Dish> order;
        private int dishGrade;
        private int serviceGrade;
        private int eatTime;
        private int timeInRestaurant;
        private double outHour;
        private Day day;
        private string outDay;
        private bool doubleDish;

        public Customer(List<Dish> order, int dishGrade, int serviceGrade, int eatTime, bool doubleDish)
        {
            this.order = order;
            this.dishGrade = dishGrade;
            this.serviceGrade = serviceGrade;
            this.eatTime = eatTime;
            timeInRestaurant = 0;
            this.doubleDish = doubleDish;
        }
        public int DishGrade
        { get { return dishGrade; } }
        public int ServiceGrade
        { get { return serviceGrade; } }
        public int EatTime
        { get { return eatTime; } }
        public List<Dish> Order { get { return order; } }
        public int TimeInRestaurant
        { get { return timeInRestaurant; } }
        public double OutHour
        { get { return outHour; } }
        public string OutDay
        { get { return outDay; } }
        public bool DoubleDish 
        { get {  return doubleDish; } }
        public int GradeDish(int dishGrade)
        {
            return dishGrade;
        }
        public int GradeService(int serviceGrade)
        {
            return serviceGrade;
        }
        public void ChangeDishGrade(int grade)
        {
            dishGrade = grade;
        }
        public void ChangeServiceGrade(int grade)
        {
            serviceGrade = grade;
        }
        public void ChangeDoubleDish(bool question)
        {
            doubleDish = question;
        }
        private int GetTimeInRestaurant()
        {
            foreach (Dish dish in order) 
            {
                timeInRestaurant = timeInRestaurant + dish.WaitTime;
            }
            timeInRestaurant = timeInRestaurant + eatTime;
            return timeInRestaurant;
        }
        public void SetOutHour(Day day)
        {
            int time = GetTimeInRestaurant();
            outHour = day.Hour + (double)time / 60;
        }
        public void SetOutDay(Day day)
        {
            outDay = day.Weekday;
        }
        public void DoubleOrder()
        {
            for (int i = 0; i < order.Count; i++)
            {
                order[i] = new DoubleDish(order[i]);
            }
        }
    }
}
