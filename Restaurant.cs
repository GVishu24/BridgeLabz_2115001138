using System;
interface Worker
{
    void PerformDuties();
}

class Person
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public virtual void DisplayRole()
    {
        Console.WriteLine("General Person");
    }
}

class Chef : Person, Worker
{
    public string Specialty { get; set; }

    public Chef(string name, int id, string specialty) : base(name, id)
    {
        Specialty = specialty;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"Chef - Specialty: {Specialty}");
    }

    public void PerformDuties()
    {
        Console.WriteLine("Preparing delicious meals");
    }
}

class Waiter : Person, Worker
{
    public int TablesAssigned { get; set; }

    public Waiter(string name, int id, int tablesAssigned) : base(name, id)
    {
        TablesAssigned = tablesAssigned;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"Waiter - Tables Assigned: {TablesAssigned}");
    }

    public void PerformDuties()
    {
        Console.WriteLine("Serving customers and taking orders");
    }
}

class Program
{
    static void Main()
    {
        Worker chef = new Chef("Alice", 101, "Italian Cuisine");
        Worker waiter = new Waiter("Bob", 102, 5);

        chef.PerformDuties();
        waiter.PerformDuties();
    }
}