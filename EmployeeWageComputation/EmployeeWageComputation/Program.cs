﻿using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            EmployeeWage wage = new EmployeeWage();
            wage.EmployeeAttendance();
        }
    }
}
