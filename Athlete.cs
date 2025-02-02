using System;
class Athlete{
	static double CalRounds(double side1, double side2, double side3){
		double perimeter = side1 + side2 + side3;
		double distance = 5000;
		double rounds = distance/ perimeter;
		return rounds;
	}
	static void Main(string[] args){
		Console.WriteLine("enter side 1 (in meters): ");
		double side1 = double.Parse(Console.ReadLine());
		Console.WriteLine("enter side 2 (in meters): ");
		double side2 = double.Parse(Console.ReadLine());
		Console.WriteLine("enter side 3 (in meters): ");
		double side3 = double.Parse(Console.ReadLine());
		
		double rounds = CalRounds(side1, side2, side3);
		Console.WriteLine("No. of rounds = "+ rounds);
	}
}
