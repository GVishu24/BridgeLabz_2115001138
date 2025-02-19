using System;
using System.Collections.Generic;

// Abstract base class for job roles
abstract class JobRole
{
    public string CandidateName { get; set; }
    public int Experience { get; set; }

    protected JobRole(string candidateName, int experience)
    {
        CandidateName = candidateName;
        Experience = experience;
    }

    public abstract void DisplayInfo();
}

// Derived classes for different job roles
class SoftwareEngineer : JobRole
{
    public string ProgrammingLanguages { get; set; }

    public SoftwareEngineer(string candidateName, int experience, string programmingLanguages)
        : base(candidateName, experience)
    {
        ProgrammingLanguages = programmingLanguages;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Software Engineer: {CandidateName}, Experience: {Experience} years, Skills: {ProgrammingLanguages}");
    }
}

class DataScientist : JobRole
{
    public string Tools { get; set; }

    public DataScientist(string candidateName, int experience, string tools)
        : base(candidateName, experience)
    {
        Tools = tools;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Data Scientist: {CandidateName}, Experience: {Experience} years, Tools: {Tools}");
    }
}

// Generic resume class with constraint
class Resume<T> where T : JobRole
{
    private List<T> candidates = new List<T>();

    public void AddCandidate(T candidate) => candidates.Add(candidate);

    public void DisplayCandidates()
    {
        foreach (var candidate in candidates)
        {
            candidate.DisplayInfo();
        }
    }
}

class Program
{
    static void Main()
    {
        // Create resume instances for different job roles
        Resume<SoftwareEngineer> softwareEngineerResumes = new Resume<SoftwareEngineer>();
        Resume<DataScientist> dataScientistResumes = new Resume<DataScientist>();

        // Add candidates to resume processing
        softwareEngineerResumes.AddCandidate(new SoftwareEngineer("Vishu", 5, "C#, Java"));
        softwareEngineerResumes.AddCandidate(new SoftwareEngineer("Jhonny", 3, "Python, JavaScript"));

        dataScientistResumes.AddCandidate(new DataScientist("Siyaram", 4, "Python, R"));
        dataScientistResumes.AddCandidate(new DataScientist("Kate", 6, "SQL, TensorFlow"));

        // Display stored candidates
        Console.WriteLine("\n--- Software Engineer Resumes ---");
        softwareEngineerResumes.DisplayCandidates();

        Console.WriteLine("\n--- Data Scientist Resumes ---");
        dataScientistResumes.DisplayCandidates();
    }
}
