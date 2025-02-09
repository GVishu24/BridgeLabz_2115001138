using System;

class Vehicle
{
    // Static variable shared across all vehicles
    private static double RegistrationFee = 500.0;
    
    // Readonly variable
    public readonly string RegistrationNumber;
    public string OwnerName;
    public string VehicleType;

    public Vehicle(string OwnerName, string VehicleType, string RegistrationNumber)
    {
        this.OwnerName = OwnerName;
        this.VehicleType = VehicleType;
        this.RegistrationNumber = RegistrationNumber;
    }

    // Static method to update registration fee
    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
        Console.WriteLine($"Registration fee updated to: {RegistrationFee}");
    }

    // Method to display vehicle details
    public void DisplayVehicleInfo()
    {
        if (this is Vehicle)  // Using 'is' operator
        {
            Console.WriteLine("=== Vehicle Registration Details ===");
            Console.WriteLine($"Owner Name: {OwnerName}");
            Console.WriteLine($"Vehicle Type: {VehicleType}");
            Console.WriteLine($"Registration Number: {RegistrationNumber}");
            Console.WriteLine($"Registration Fee: {RegistrationFee}");
        }
    }
}

class Program
{
    static void Main()
    {
        Vehicle.UpdateRegistrationFee(800.0);

        Vehicle vehicle1 = new Vehicle("Vishu Gupta", "Car", "BAC1234");
        Vehicle vehicle2 = new Vehicle("Mia Khalifa", "Motorcycle", "XYZ5678");
        
        vehicle1.DisplayVehicleInfo();
        vehicle2.DisplayVehicleInfo();
    }
}