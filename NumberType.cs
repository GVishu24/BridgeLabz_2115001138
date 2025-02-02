using System;
class NumberType{
	static void Main(string [] args){
		
		int [] num = new int[5];
		Console.WriteLine("enter five numbers: ");
		for (int i = 0; i < num.Length; i++){
			num[i]= int.Parse(Console.ReadLine());
		}
		foreach(int n in num){
			if (n > 0){
				Console.WriteLine("it is a + no.");
				if(n % 2 ==0){
					Console.WriteLine("even");
				}
				else{
					Console.WriteLine("odd");
				}
			}
			else if (n < 0){
				Console.WriteLine("-vs no.");
			}
			else if(n ==0){
				Console.WriteLine("zero");
			}
			else{
				Console.WriteLine("enter valid integer");
			}
			
		}Console.WriteLine("compare num1 and num5");
		string result = num[0] > num[4]? "num 1 is greater" : num[0] < num[4]? "num 2 is greater": "both are equal";
		Console.WriteLine(result);
	}
}
		
					
					
		
