using System;
using System.Collections.Generic;

abstract class Employee
{
    private int employeeId;
    private string name;
    private double baseSalary;

    // Constructor
    public Employee(int id, string empName, double salary)
    {
        employeeId = id;
        name = empName;
        baseSalary = salary;
    }

    // Properties for Encapsulation
    public int EmployeeId { get { return employeeId; } }
    public string Name { get { return name; } }
    public double BaseSalary { get { return baseSalary; } }

    public abstract double CalculateSalary();

    // Concrete Method to Display Employee Details
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Base Salary: {BaseSalary:C}");
    }
}

// Interface for Department Handling
interface IDepartment
{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

// Full-Time Employee Class
class FullTimeEmployee : Employee, IDepartment
{
    private double bonus;
    private string department;

    // Constructor
    public FullTimeEmployee(int id, string name, double salary, double bonus) 
        : base(id, name, salary)
    {
        this.bonus = bonus;
    }

    // Override CalculateSalary
    public override double CalculateSalary()
    {
        return BaseSalary + bonus;
    }

    public void AssignDepartment(string dept)
    {
        department = dept;
    }

    public string GetDepartmentDetails()
    {
        return $"Department: {department}";
    }

    // Override DisplayDetails
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Bonus: {bonus:C}, Total Salary: {CalculateSalary():C}");
        Console.WriteLine(GetDepartmentDetails());
    }
}

class PartTimeEmployee : Employee, IDepartment
{
    private int workHours;
    private double hourlyRate;
    private string department;

    public PartTimeEmployee(int id, string name, double hourlyRate, int workHours) 
        : base(id, name, 0)  // Base salary is not applicable for part-time employees
    {
        this.hourlyRate = hourlyRate;
        this.workHours = workHours;
    }

    // Override CalculateSalary
    public override double CalculateSalary()
    {
        return workHours * hourlyRate;
    }

    public void AssignDepartment(string dept)
    {
        department = dept;
    }

    public string GetDepartmentDetails()
    {
        return $"Department: {department}";
    }

    // Override DisplayDetails
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Hourly Rate: {hourlyRate:C}, Work Hours: {workHours}, Total Salary: {CalculateSalary():C}");
        Console.WriteLine(GetDepartmentDetails());
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        FullTimeEmployee emp1 = new FullTimeEmployee(1, "Alice", 50000, 5000);
        emp1.AssignDepartment("IT");
        employees.Add(emp1);

        PartTimeEmployee emp2 = new PartTimeEmployee(2, "Bob", 20, 120);
        emp2.AssignDepartment("HR");
        employees.Add(emp2);

        Console.WriteLine("Employee Details:\n");
        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
            Console.WriteLine("------------------------");
        }
    }
}
