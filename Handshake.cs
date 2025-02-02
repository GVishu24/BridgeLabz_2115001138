using System;
class HandShake{
	static int CalculateHandshake(int n){
		return (n * (n - 1)) / 2;
	}
	static void Main(string[] args){
		Console.WriteLine("Enter no. of students: ");
		int n = int.Parse(Console.ReadLine());
		
		int handshake = CalculateHandshake(n);
		Console.WriteLine("no. of handshakes = "+handshake);
	}
}

