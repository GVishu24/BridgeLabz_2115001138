using System;
class Average
{
	static double calculateAverage(int maths, int physics, int chemistry)
	{
		return (maths + physics + chemistry) / 3.0;
	}
	static void Main(string[] args)
	{
		int maths = 95;
		int physics = 96;
		int chemistry = 100;
		double res = calculateAverage(maths, physics, chemistry);
		Console.WriteLine("Sam’s average mark in PCM is " + res);
	}
}


