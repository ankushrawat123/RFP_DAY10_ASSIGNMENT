﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_DAY10_ASSIGNMENT
{
    internal class Wage_To_Multiple_Company
    {
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;

        public const int maxHoursPerMonth = 100;
        public const int numOfWorkingDays = 20;
        public int EmpWageForCompany(String company, int empRatePerHour, int numOfWorkingDays,int maxHourPerMonth)
        {
           
           
            int totalWorkingDays = 0;
            int empHrs = 0;
            int totalEmpHrs = 0;

            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random obj = new Random();
                int num = obj.Next(0, 3);
                switch (num)
                {
                    case Is_Full_Time:
                        empHrs = 8;
                        break;

                    case Is_Part_Time:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs += empHrs;
                Console.WriteLine("Days : {0} Emp Hours : {1}", totalWorkingDays, empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Employee Wage for company: " + totalEmpWage);

            return totalEmpWage;
        }
       
    }
}
