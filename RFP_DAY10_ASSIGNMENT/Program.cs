// See https://aka.ms/new-console-template for more information
using RFP_DAY10_ASSIGNMENT;
Console.WriteLine(" \nWelcome to Employee Attendance Program .............................................");
int Is_Full_Time = 1;
Random obj = new Random();
int num = obj.Next(0, 2);
Attendance obj3 = new Attendance();
obj3.attendanceMethod(Is_Full_Time, num);
