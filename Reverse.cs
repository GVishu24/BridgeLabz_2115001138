using System;
class Reverse{
	static void Main(string [] args){
		Console.WriteLine("Enter a String: ");
		string text = Console.ReadLine();
		string reversed = "";
		text = text.ToLower();
		for (int i = text.Length-1; i >=0 ; i--){
			reversed+=text[i];
		}
		Console.WriteLine("Reversed string = "+ reversed);
		
		
		
		if (reversed == text){
			Console.WriteLine("Pallindrome");
		}
		else{
			Console.WriteLine(" not Pallindrome");
		}
	}
}
