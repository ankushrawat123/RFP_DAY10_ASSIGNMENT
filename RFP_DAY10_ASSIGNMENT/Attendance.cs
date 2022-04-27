using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_DAY10_ASSIGNMENT
{
    internal class Attendance
    {
        public void attendanceMethod(int Is_Full_Time, int num)
        {

            if (num == Is_Full_Time)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

        }
    }
}
