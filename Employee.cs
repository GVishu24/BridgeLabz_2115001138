using System;
class Employee
{
    // Attributes
    public string Name { get; set; }
    public int Id { get; set; }
    public decimal Salary { get; set; }

    // Constructor
    public Employee(string name, int id, decimal salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine($"Employee Name: {Name}");
        Console.WriteLine($"Employee ID: {Id}");
        Console.WriteLine($"Employee Salary: ${Salary:F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Employee
        Employee emp1 = new Employee("John Doe", 101, 75000m);
        
        // Displaying the details of the employee
        emp1.DisplayDetails();
    }
}