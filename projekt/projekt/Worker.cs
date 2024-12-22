using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    abstract class Worker
    {
        private double allMoney = 0;
        public double AllMoney
        { get { return allMoney; } }
        public abstract double Payment();
        public void AddAllMoney(double money)
        {
            allMoney += money;
        }
    }
}
