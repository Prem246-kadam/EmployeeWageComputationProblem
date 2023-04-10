using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int totalHrs = 0;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int NUMBER_OF_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 100;

            //welcome message
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            //UC1-EmployeeAttendance
            Random random = new Random();
            while (day <= NUMBER_OF_WORKING_DAYS && totalHrs <= MAX_WORKING_HRS)
            {
                int employeeAttendance = random.Next(0, 3); //0 to 2
                switch (employeeAttendance)
                {
                    case IS_FULL_TIME:
                        //code block
                        Console.WriteLine("Employee is Full-time Present");
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        //code block
                        Console.WriteLine("Employee is Part-time Present");
                        empHrs = 4;
                        break;
                    default:
                        //code block
                        Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;
                }
                //UC2
                empWage = EMP_RATE_PER_HR * empHrs;
                Console.WriteLine("Employee Wage for day{0} and {1}hrs is:{2} ", day, empHrs, empWage);
                //totalWage = totalWage + empWage;
                day++;
                totalHrs += empHrs;
                totalWage += empWage;
            }
            //Console.WriteLine("Employee wage is:" +empWage);
            Console.WriteLine("Total Wage for {0} days and {1} hrs is:{2} ", (day - 1), totalHrs, totalWage);
            Console.ReadLine();
        }
    }
}