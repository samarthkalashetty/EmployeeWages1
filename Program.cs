namespace EmployeeWages1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation!");

            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            int empHour = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 2);

            Console.WriteLine(empCheck);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Is Present");
                empHour = 9;
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
                empWage = 0;
            }
            empWage += empHour * EMP_RATE_PER_HOUR;
            Console.WriteLine("EmpWage :" + empWage);

        }
    }
