﻿using System;
namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        public void EmployeeAttendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);// returns the value 0, 1
            if(empCheck == 0)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}