using System;

class Patient
{
    // Static variable shared across all patients
    private static string HospitalName = "City General Hospital";
    private static int totalPatients = 0;
    
    // Readonly variable
    public readonly int PatientID;
    public string Name;
    public int Age;
    public string Ailment;

    public Patient(int PatientID, string Name, int Age, string Ailment)
    {
        this.PatientID = PatientID;
        this.Name = Name;
        this.Age = Age;
        this.Ailment = Ailment;
        totalPatients++;
    }

    // Static method to get total patients count
    public static void GetTotalPatients()
    {
        Console.WriteLine($"Total Patients Admitted: {totalPatients}");
    }

    // Method to display patient details
    public void DisplayPatientInfo()
    {
        if (this is Patient) 
        {
            Console.WriteLine("=== Patient Details ===");
            Console.WriteLine($"Hospital: {HospitalName}");
            Console.WriteLine($"Patient ID: {PatientID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Ailment: {Ailment}");
        }
    }
}

class Program
{
    static void Main()
    {
        Patient patient1 = new Patient(101, "James Bond", 26, "Flu");
        Patient patient2 = new Patient(102, "Mia Malkova", 25, "Fracture");
        
        patient1.DisplayPatientInfo();
        patient2.DisplayPatientInfo();
        
        Patient.GetTotalPatients();
    }
}
