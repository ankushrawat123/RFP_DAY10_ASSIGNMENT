using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_DAY10_ASSIGNMENT
{
    internal class WageUc
    {
        public void Wage(int Is_Full_Time,int Emp_Rate_Per_Hour)
        {

            int empHrs = 0;
            int empWage = 0;
            Random obj = new Random();
            int num = obj.Next(0, 2);
            if (num == Is_Full_Time)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee wage : " + empWage);
        }
    }
}
