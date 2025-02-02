using System;
class WindChill{
	public double CalculateWindChill(double temperature, double windSpeed){
		double windChill = 35.74 + 0.6215 *temperature + (0.4275*temperature - 35.75) * windSpeed*0.16;
		return windChill;
	}
	static void Main(string[] args){
		Console.WriteLine("Enter the temperature: ");
		double temperature = double.Parse(Console.ReadLine());
		Console.WriteLine("Enter the windSpeed: ");
		double windSpeed = double.Parse(Console.ReadLine());
		
		WindChill wc = new WindChill();
		Console.WriteLine(wc.CalculateWindChill(temperature, windSpeed));
	}
}

