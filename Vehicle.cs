using System;
using System.Collections.Generic;

// Abstract Vehicle Class
abstract class Vehicle
{
    // Encapsulated Fields
    private string vehicleNumber;
    private string type;
    private double rentalRate;

    // Constructor
    public Vehicle(string number, string vehicleType, double rate)
    {
        vehicleNumber = number;
        type = vehicleType;
        rentalRate = rate;
    }

    // Properties for Encapsulation
    public string VehicleNumber { get { return vehicleNumber; } }
    public string Type { get { return type; } }
    public double RentalRate { get { return rentalRate; } }

    // Abstract Method for Rental Cost Calculation
    public abstract double CalculateRentalCost(int days);

    // Display Vehicle Details
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Vehicle Number: {VehicleNumber}, Type: {Type}, Rental Rate: {RentalRate:C} per day");
    }
}

// Interface for Insurable Vehicles
interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

// Car Class (Implements IInsurable)
class Car : Vehicle, IInsurable
{
    private double insuranceRate = 0.05; // 5% of rental rate per day
    private string insurancePolicyNumber;

    // Constructor
    public Car(string number, double rate, string policyNumber)
        : base(number, "Car", rate)
    {
        insurancePolicyNumber = policyNumber;
    }

    // Implement Rental Cost Calculation
    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    // Implement IInsurable Methods
    public double CalculateInsurance()
    {
        return RentalRate * insuranceRate;
    }

    public string GetInsuranceDetails()
    {
        return $"Insurance Policy: [Protected], Daily Insurance Cost: {CalculateInsurance():C}";
    }

    // Override DisplayDetails
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine(GetInsuranceDetails());
    }
}

// Bike Class (Lower Rental, Lower Insurance)
class Bike : Vehicle, IInsurable
{
    private double insuranceRate = 0.02; // 2% of rental rate per day
    private string insurancePolicyNumber;

    // Constructor
    public Bike(string number, double rate, string policyNumber)
        : base(number, "Bike", rate)
    {
        insurancePolicyNumber = policyNumber;
    }

    // Implement Rental Cost Calculation
    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    // Implement IInsurable Methods
    public double CalculateInsurance()
    {
        return RentalRate * insuranceRate;
    }

    public string GetInsuranceDetails()
    {
        return $"Insurance Policy: [Protected], Daily Insurance Cost: {CalculateInsurance():C}";
    }

    // Override DisplayDetails
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine(GetInsuranceDetails());
    }
}

// Truck Class (Higher Rental, Higher Insurance)
class Truck : Vehicle, IInsurable
{
    private double insuranceRate = 0.10; // 10% of rental rate per day
    private string insurancePolicyNumber;

    // Constructor
    public Truck(string number, double rate, string policyNumber)
        : base(number, "Truck", rate)
    {
        insurancePolicyNumber = policyNumber;
    }

    // Implement Rental Cost Calculation
    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    // Implement IInsurable Methods
    public double CalculateInsurance()
    {
        return RentalRate * insuranceRate;
    }

    public string GetInsuranceDetails()
    {
        return $"Insurance Policy: [Protected], Daily Insurance Cost: {CalculateInsurance():C}";
    }

    // Override DisplayDetails
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine(GetInsuranceDetails());
    }
}

// Vehicle Rental System with Polymorphism
class VehicleRentalSystem
{
    public static void ProcessRentals(List<Vehicle> vehicles, int rentalDays)
    {
        Console.WriteLine("\nVehicle Rental Cost Calculation:\n");

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayDetails();
            double rentalCost = vehicle.CalculateRentalCost(rentalDays);
            double insuranceCost = vehicle is IInsurable insurable ? insurable.CalculateInsurance() * rentalDays : 0;

            Console.WriteLine($"Total Rental Cost for {rentalDays} days: {rentalCost:C}");
            Console.WriteLine($"Total Insurance Cost for {rentalDays} days: {insuranceCost:C}");
            Console.WriteLine($"Final Price (Rental + Insurance): {(rentalCost + insuranceCost):C}");
            Console.WriteLine("------------------------");
        }
    }

    static void Main()
    {
        // Create a list of vehicles
        List<Vehicle> vehicles = new List<Vehicle>();

        // Adding vehicles
        Car sedan = new Car("CAR123", 50, "INS12345");
        Bike scooter = new Bike("BIKE456", 20, "INS67890");
        Truck lorry = new Truck("TRUCK789", 100, "INS54321");

        vehicles.Add(sedan);
        vehicles.Add(scooter);
        vehicles.Add(lorry);

        // Number of rental days
        int rentalDays = 5;

        // Process rental calculations
        ProcessRentals(vehicles, rentalDays);
    }
}
