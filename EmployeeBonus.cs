using System;

public class EmployeeBonusCalculator
{
    // Method to generate salaries and years of service for employees
    public static int[,] GenerateEmployeeData(int numberOfEmployees)
    {
        Random random = new Random();
        int[,] employeeData = new int[numberOfEmployees, 2]; // [Salary, Years of Service]

        for (int i = 0; i < numberOfEmployees; i++)
        {
            employeeData[i, 0] = random.Next(30000, 100000); // Random salary between 30,000 and 100,000
            employeeData[i, 1] = random.Next(1, 11); // Random years of service between 1 and 10
        }

        return employeeData;
    }

    // Method to calculate new salary and bonus for employees
    public static double[,] CalculateNewSalariesAndBonuses(int[,] employeeData)
    {
        int numberOfEmployees = employeeData.GetLength(0);
        double[,] updatedData = new double[numberOfEmployees, 2]; // [New Salary, Bonus]

        for (int i = 0; i < numberOfEmployees; i++)
        {
            int oldSalary = employeeData[i, 0];
            int yearsOfService = employeeData[i, 1];
            double bonusPercentage = yearsOfService > 5 ? 0.05 : 0.02;
            double bonus = oldSalary * bonusPercentage;
            double newSalary = oldSalary + bonus;

            updatedData[i, 0] = newSalary;
            updatedData[i, 1] = bonus;
        }

        return updatedData;
    }

    // Method to calculate and display the summary of salaries and bonuses
    public static void DisplaySalarySummary(int[,] employeeData, double[,] updatedData)
    {
        int numberOfEmployees = employeeData.GetLength(0);
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        Console.WriteLine("Employee\tOld Salary\tYears of Service\tBonus\tNew Salary");
        Console.WriteLine("-------------------------------------------------------------");

        for (int i = 0; i < numberOfEmployees; i++)
        {
            int oldSalary = employeeData[i, 0];
            int yearsOfService = employeeData[i, 1];
            double bonus = updatedData[i, 1];
            double newSalary = updatedData[i, 0];

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            Console.WriteLine($"{i + 1}\t{oldSalary}\t\t{yearsOfService}\t\t{bonus:F2}\t{newSalary:F2}");
        }

        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine($"Total\t{totalOldSalary:F2}\t\t\t{totalBonus:F2}\t{totalNewSalary:F2}");
    }

    public static void Main(string[] args)
    {
        int numberOfEmployees = 10;

        // Step 1: Generate employee data
        int[,] employeeData = GenerateEmployeeData(numberOfEmployees);

        // Step 2: Calculate new salaries and bonuses
        double[,] updatedData = CalculateNewSalariesAndBonuses(employeeData);

        // Step 3: Display the salary summary
        DisplaySalarySummary(employeeData, updatedData);
    }
}




import java.util.Random;

public class EmployeeBonusCalculator {

    public static void main(String[] args) {
        // Step 1: Get salaries and years of service
        double[][] employeeData = generateEmployeeData(10);

        // Step 2: Calculate new salaries and bonuses
        double[][] newSalaryAndBonus = calculateNewSalariesAndBonuses(employeeData);

        // Step 3: Calculate and display the sums
        calculateAndDisplaySums(employeeData, newSalaryAndBonus);
    }

    // Method to generate random salaries and years of service
    public static double[][] generateEmployeeData(int numEmployees) {
        Random random = new Random();
        double[][] employeeData = new double[numEmployees][2]; // 2D Array to hold [salary, years of service]

        for (int i = 0; i < numEmployees; i++) {
            // Generate a random salary between 10000 and 99999
            employeeData[i][0] = 10000 + (random.nextDouble() * 90000);
            // Generate random years of service between 0 and 20
            employeeData[i][1] = random.nextInt(21);
        }

        return employeeData;
    }
