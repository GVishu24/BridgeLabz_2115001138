using System;
class Operator
{
	static void Main(string[] args)
	{
		/* unary
		int a = 5;

		Console.WriteLine("a: " + a); 
		Console.WriteLine("++a: " + ++a); 
		Console.WriteLine("a++: " + a++); 
		Console.WriteLine("a: " + a); 
		Console.WriteLine("--a: " + --a); 
		Console.WriteLine("a--: " + a--); 
		Console.WriteLine("a: " + a); 
		*/
		
		/* bitwise
		int a = 5; 
		int b = 3;

		Console.WriteLine("a & b: " + (a & b)); 
		Console.WriteLine("a | b: " + (a | b)); 
		Console.WriteLine("a ^ b: " + (a ^ b)); 
		Console.WriteLine("~a: " + (~a));
		Console.WriteLine("a << 1: " + (a << 1)); 
		Console.WriteLine("a >> 1: " + (a >> 1)); 
		*/
		
		//ternary
		int number = 10;
		string result = (number % 2 ==0) ? "Even" : "odd";
		Console.WriteLine("The number "+ number + " is " + result);
		
		
	}
}
