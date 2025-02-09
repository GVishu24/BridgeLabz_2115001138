using System;

class Employee
{
    // Static variable shared across all employees
    private static string CompanyName = "TechCorp";
    private static int totalEmployees = 0;
    
    // Readonly variable
    public readonly int Id;
    public string Name;
    public string Designation;

    // Constructor using 'this' to resolve ambiguity
    public Employee(string Name, int Id, string Designation)
    {
        this.Name = Name;
        this.Id = Id;
        this.Designation = Designation;
        totalEmployees++;
    }

    // Static method to display total employees
    public static void DisplayTotalEmployees()
    {
        Console.WriteLine($"Total Employees: {totalEmployees}");
    }

    // Method to display employee details
    public void DisplayEmployeeInfo()
    {
        if (this is Employee)  // Using 'is' operator
        {
            Console.WriteLine("=== Employee Details ===");
            Console.WriteLine($"Company: {CompanyName}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Designation: {Designation}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Creating employee objects
        Employee emp1 = new Employee("Alice Johnson", 101, "Software Engineer");
        Employee emp2 = new Employee("Bob Smith", 102, "Project Manager");
        
        // Display employee details
        emp1.DisplayEmployeeInfo();
        emp2.DisplayEmployeeInfo();
        
        // Display total employees
        Employee.DisplayTotalEmployees();
    }
}
