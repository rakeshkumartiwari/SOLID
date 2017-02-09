using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Single_Responsibility
{
    // EMPLOYEE CLASS HAS 3 REASONS TO CHANGE. 
    // VIOLATING SINGLE RESPONSIBILITY PRINCIPLE
    //CALCULATE PAY : IT KNOWS HOW TO CALCULATE PAYMENT
    //SAVE: IT KNOW WHERE AND HOW TO SAVE
    //DESCRIBE: IT KNOWS HOW TO GET ALL INFORMATION OF EMPLOYEE

    //RULE: THERE SHOULD BE ONLY ONE REASON TO CHANGE A CLASS

    public class Employee
    {
        public Pay CalculatePay() { return new Pay(23); }
        public void Save() { }
        public string DescribeEmployee() { return "employee description"; }
    }

    public class Pay
    {
        private int ammount;
        public Pay(int ammount)
        {
            this.ammount = ammount;
        }
    }
}
