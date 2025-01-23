using System;
class EmployeeBonus
{
    static void Main()
    {
        // Input: Get salary and years of service from the user
        Console.WriteLine("Enter the employee's salary:");
        double salary = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the employee's years of service:");
        int yearsOfService = int.Parse(Console.ReadLine());

        // Check if years of service is more than 5
        if (yearsOfService > 5)
        {
            // Calculate the bonus (5% of the salary)
            double bonus = 0.05 * salary;

            // Output the bonus amount
            Console.WriteLine("The bonus amount is: " + bonus);
        }
        else
        {
            // Output: No bonus
            Console.WriteLine("No bonus for employees with 5 years or less of service.");
        }
    }
}
