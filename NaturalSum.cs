using System;
class NaturalSum{
	static void Main(string[] args){
		// taking user input
		Console.WriteLine("Enter a number: ");
		int num = int.Parse(Console.ReadLine());
		// checking if the number is natural and finding the sum 
		if (num >= 0){
			int sum = (num * (num + 1))/2;
			// output
			Console.WriteLine(string.Format("The number {0} is a natural number and the sum of {0} natural number is {1}",num, sum));
		}
		else{
			// if invalid input
			Console.WriteLine("The number "+ num + " is not a natural number");
		}
	}
}



