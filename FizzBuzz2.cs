using System;
class Buzz{
	static void Main(string[] args){
		//Input from user
		Console.Write("Enter a number for FizzBuzz: ");
		int num = Convert.ToInt32(Console.ReadLine());
		//variable for loop 
		int i =0;
		while(i<=num){
			//check for divisible by 3 and 5
			if (i%3==0 && i%5==0){
				Console.WriteLine("Fizz Buzz");}
			// check for divisible by 3
			else if (i%3==0){
				Console.WriteLine("Fizz");
			}
			//check for divisible by 5
			else if (i%5==0){
				Console.WriteLine("Buzz");
			}
			//output number
			else{
				Console.WriteLine($"{i}");
			}
			i++;
		}
	}
}
