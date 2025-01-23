using System;
class Div5{
	static void Main(string[] args){
		Console.WriteLine("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		if (number % 5 == 0){
			Console.WriteLine("Number is divisible by 5");
		}
		else{
			Console.WriteLine("Number is not divisible by 5");
		}
	}
}

		