namespace EmployeeWages1
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUMBER_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;

        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation!");

            int empHour = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;

            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUMBER_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHour = 4;
                        break;
                    case IS_FULL_TIME:
                        empHour = 8;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                totalEmpHrs += empHour;
                Console.WriteLine("Days :" + totalWorkingDays + "EmpHrs : " + empHour);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total EmpWage: " + totalEmpWage);
        }
    }
}