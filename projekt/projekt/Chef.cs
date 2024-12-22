using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Chef : Worker
    {
        private int customersCount;
        private int grade;
        private int payment;
        
        public Chef(int payment)
        {
            this.payment = payment;
            grade = 0;
            customersCount = 0;
        }
        public int Grade
        { get { return grade; } }
        public int CustomersCount
        { get { return customersCount; } }
        public override double Payment()
        {
       
            double averageGrade = (double)grade / customersCount;
            if (averageGrade >= 4)
            {
                return payment + 10*averageGrade;
            }
            else if (averageGrade >= 3)
            {
                return payment;
            }
            else
            {
                return payment - 10*averageGrade;
            }
        }
        public void SetGrade(int clientGrade)
        {
            grade = grade + clientGrade;
            customersCount++;
        }
        public void Reset()
        {
            grade = 0;
            customersCount = 0;
        }
    }
}

