using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_DAY10_ASSIGNMENT
{
    public class @interface
    {

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;


        public @interface(String company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth)
        {

            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHourPerMonth;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp Wage for company :" + this.company + "is : " + this.totalEmpWage;
        }

    }
}