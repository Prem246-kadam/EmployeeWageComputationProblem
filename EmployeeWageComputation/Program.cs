using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            Console.WriteLine("Total Wage is: " + CalculateEmpWage("Deloitte", 40, 23, 60)+"\n");
            Console.WriteLine("Total Wage is: " + CalculateEmpWage("Microsoft", 50, 26, 70)+"\n");
            Console.WriteLine("Total Wage is: " + CalculateEmpWage("Infosys", 70, 33, 65)+"\n");
            Console.WriteLine("Total Wage is: " + CalculateEmpWage("Accenture", 60, 36, 55)+"\n");
            Console.WriteLine("Total Wage is: " + CalculateEmpWage("Capgemini", 50, 30, 68)+"\n");
        }
        public static int CalculateEmpWage(string companyName, int empRatePerHr, int numOfWorkingDays, int maxWorkingHrs)
        {
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int totalHrs = 0;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;

            Random random = new Random();
            while (day <= numOfWorkingDays && totalHrs <= maxWorkingHrs)
            {
                int employeeAttendance = random.Next(0, 3); //0 to 2
                switch (employeeAttendance)
                {
                    case IS_FULL_TIME:
                        //code block
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        //code block
                        empHrs = 4;
                        break;
                    default:
                        //code block
                        empHrs = 0;
                        break;
                }
                empWage = empRatePerHr * empHrs;
                day++;
                totalHrs += empHrs;
                totalWage += empWage;
            }
            Console.WriteLine("Total Wage for {0} {1} days and {2} hrs is:{3} ", companyName, (day - 1), totalHrs, totalWage);
            return totalWage;
        }
    }
}
