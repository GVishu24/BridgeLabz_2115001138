using System;
class NumberType{
	static int CheckNumber(int n){
		if (n < 0){
			return -1;
		}
		else if (n > 0){
			return 1;
		}
		else{
			return 0;
		}
	}
	static void Main(string[] args){
		Console.WriteLine("Enter an integer: ");
		int n = int.Parse(Console.ReadLine());
		int res = CheckNumber(n);
		Console.WriteLine(res);
	}
}