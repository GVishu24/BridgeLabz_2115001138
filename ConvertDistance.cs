using System;
class ConvertDistance{
	static double kmToMiles(double km){
		return km * 1.6;
	}
	static void Main(string[] args ){
		double km = 10;
		double res = kmToMiles(km);
		Console.WriteLine("The distance " +km + "km in miles is " + res);
	}
}

	