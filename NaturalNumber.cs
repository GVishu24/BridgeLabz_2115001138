using System;
class NaturalNumber{
	public void CheckNumber(int n){
		if (n > 0){
			Console.WriteLine("Number is a natural number");
			int sum = 0;
			for (int i=0; i<n; i++){
				sum+=i;
			}
			Console.WriteLine(string.Format("The sum of {0} natural numbers is {1}",n,sum ));
		}
		else{
		Console.WriteLine("Number is not a natural number");
		}
		
	}
	static void Main(string[] args){
		Console.WriteLine("Enter a number: ");
		int n = int.Parse(Console.ReadLine());
		NaturalNumber checkNumber = new NaturalNumber();
		checkNumber.CheckNumber(n);
	}
}
		
			
		