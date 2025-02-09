using System;

interface Refuelable
{
    void Refuel();
}

class Vehicle
{
    public string Model { get; set; }
    public int MaxSpeed { get; set; }

    public Vehicle(string model, int maxSpeed)
    {
        Model = model;
        MaxSpeed = maxSpeed;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Vehicle Model: {Model}, Max Speed: {MaxSpeed} km/h");
    }
}

class ElectricVehicle : Vehicle
{
    public int BatteryCapacity { get; set; }

    public ElectricVehicle(string model, int maxSpeed, int batteryCapacity) : base(model, maxSpeed)
    {
        BatteryCapacity = batteryCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Battery Capacity: {BatteryCapacity} kWh");
    }

    public void Charge()
    {
        Console.WriteLine("Charging the electric vehicle...");
    }
}

class PetrolVehicle : Vehicle, Refuelable
{
    public int FuelCapacity { get; set; }

    public PetrolVehicle(string model, int maxSpeed, int fuelCapacity) : base(model, maxSpeed)
    {
        FuelCapacity = fuelCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Fuel Capacity: {FuelCapacity} liters");
    }

    public void Refuel()
    {
        Console.WriteLine("Refueling the petrol vehicle...");
    }
}

class Program
{
    static void Main()
    {
        ElectricVehicle ev = new ElectricVehicle("Tesla Model S", 250, 100);
        PetrolVehicle pv = new PetrolVehicle("Ford Mustang", 240, 60);

        ev.DisplayInfo();
        ev.Charge();

        Console.WriteLine();

        pv.DisplayInfo();
        pv.Refuel();
    }
}