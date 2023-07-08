namespace EmployeeWages1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation!");

            int IS_FULL_TIME = 0;
            Random random = new Random();
            int empCheck = random.Next(1, 2);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }
        }
    }
}



