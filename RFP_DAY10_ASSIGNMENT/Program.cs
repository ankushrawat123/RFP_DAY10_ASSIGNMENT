﻿// See https://aka.ms/new-console-template for more information
using RFP_DAY10_ASSIGNMENT;

int Is_Full_Time = 1;
int Is_Part_Time = 2;
int Emp_Rate_Per_Hour = 20;
Console.WriteLine("Enter \n1 for ATTENDANCE PROGRAM \n2 for WAGE PROGRAM \n3 for PART PROGRAM\n4 for SWITCH_WAGE PROGRAM\n5 for Working_20_Days PROGRAM  \n6 for MAX100HOURS PROGRAM ");
int Option = Convert.ToInt32(Console.ReadLine());
switch (Option)
{
    case 1:
        Console.WriteLine(" \n Welcome to Employee Attendance Program .............................................");
        Random obj = new Random();
        int num = obj.Next(0, 2);
        Attendance obj1 = new Attendance();
        obj1.attendanceMethod(Is_Full_Time, num);
        break;

    case 2:
        WageUc obj2 = new WageUc();
        obj2.Wage(Is_Full_Time, Emp_Rate_Per_Hour);
        break;

    case 3:
        ParttimeUc obj3 = new ParttimeUc();
        obj3.Wage(Is_Full_Time, Is_Part_Time, Emp_Rate_Per_Hour);
        break;

    case 4:
        SwitchWageUc obj4 = new SwitchWageUc();
        obj4.EmpWage();
        break;
    case 5:
        Working20DaysUc obj5 = new Working20DaysUc();
        obj5.Emp20DaysWage();
        break;
    case 6:
        Max100hours obj6 = new Max100hours();
        obj6.EmpMax100HrsWage();
        break;
}