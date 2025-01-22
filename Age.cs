using System;
class Age
{
	// function to calculate age
	static int ageIn2024(int birthYear, int currentYear)
	{
		return currentYear-birthYear;
	}
	static void Main(string[] args)
	{
		int currentYear = 2024;
		int birthYear = 2000;
		// calling function
		int res = ageIn2024(birthYear,currentYear);
		// display
		Console.WriteLine("Harry's age in 2024 is " +res);
	
	}
}