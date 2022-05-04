// See https://aka.ms/new-console-template for more information
using RFP_DAY10_ASSIGNMENT;

int Is_Full_Time = 1;
int Is_Part_Time = 2;
int Emp_Rate_Per_Hour = 20;
Console.WriteLine("Enter \n1 for ATTENDANCE PROGRAM \n2 for WAGE PROGRAM \n3 for PARTTIME PROGRAM\n4 for SWITCH_WAGE PROGRAM\n5 for Working_20_Days PROGRAM \n6 for MAXIMUM_100_HOURS PROGRAM \n7 for Wage_Method PROGRAM \n8 for Wage_To_Multiple_Company PROGRAM \n9 for EMP_WAGE_USING_OBJECT PROGRAM \n10 for EMP_WAGE_USING_INTERFACE_APPROACH PROGRAM");
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

    case 7:
       Using_Wage_Method obj7 = new Using_Wage_Method();
        obj7.wageMethod();
        break;

    case 8:
        Wage_To_Multiple_Company obj8 = new Wage_To_Multiple_Company();
        Console.WriteLine("Company - 1");
        obj8.EmpWageForCompany("DMart", 20, 2, 10);
        Console.WriteLine("Company - 2");
        obj8.EmpWageForCompany("Reliance", 10, 4, 20);
        break;

    case 9:
        Emp_Wage_Using_obj dMart = new Emp_Wage_Using_obj("DMart",20,2,10);
        Emp_Wage_Using_obj reliance = new Emp_Wage_Using_obj("Reliance",10,4,20);
        dMart.computeEmpWage();
        Console.WriteLine(dMart.ToString());
        Console.WriteLine(reliance.ToString());
        break;

    case 10:
        EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
        empWageBuilder.addCompanyEmpWage("DMart",20,2,10);
        empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
        empWageBuilder.computeEmpWage();
        break;
}