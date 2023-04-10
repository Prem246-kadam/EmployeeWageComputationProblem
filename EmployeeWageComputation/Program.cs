using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            //welcome message
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            //UC1-EmployeeAttendance
            Random random = new Random();
            int employeeAttendance = random.Next(0, 2); //0 or 1
            if (employeeAttendance == isPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}