namespace EmployeeWages1
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUMBER_OF_WORKING_DAYS = 2;

        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation!");

            int empHour = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            for (int day = 0; day < NUMBER_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)

                {
                    case IS_PART_TIME:
                        Console.WriteLine("Part Time Employee Is Present");
                        empHour = 4;
                        break;
                    case IS_FULL_TIME:
                        Console.WriteLine("Full Time Employee Is Present");
                        empHour = 8;
                        break;
                    default:
                        Console.WriteLine("Part Time Employee Is Absent");
                        empHour = 0;
                        break;
                }
                day++;

                empWage = empHour * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("EmpWage :" + empWage);
            }
            Console.WriteLine("Total EmpWage: " + totalEmpWage);
        }
    }
}