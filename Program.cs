namespace EmployeeWages1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation!");

            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;

            int empHour = 0;
            int empWage = 0;

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
            empWage = empHour * EMP_RATE_PER_HOUR;
            Console.WriteLine("EmpWage :" + empWage);

        }
    }
}