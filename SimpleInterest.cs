using System;
class SimpleInterest{
	static double CalculateSi(double principle, double rate, double time){
		return (principle*rate*time)/100;
	}
	
	static void Main(string[] args){
		Console.WriteLine("Enter principle: ");
		double principle = double.Parse(Console.ReadLine());
		Console.WriteLine("Enter rate: ");
		double rate = double.Parse(Console.ReadLine());
		Console.WriteLine("Enter time: ");
		double time = double.Parse(Console.ReadLine());
		
		double si = CalculateSi(principle, rate, time);
		Console.WriteLine(si);
	}
}
