using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    abstract class CustomerFactory
    {
        protected int mode;
        protected List<Dish> dish;

        public int Mode
        {
            get { return mode; }
        }
        public abstract Customer MakeCustomer();
    
        public void SetProductionMode(int mode)
        { this.mode = mode; }

    }
}
