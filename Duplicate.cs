using System;
class Duplicate{
	static void Main(string[] args){
		Console.WriteLine("Enter a string: ");
		string input = Console.ReadLine();
		string result = "";
		
		foreach (char c in input){
			bool isDuplicate = false;
			
			for (int i = 0; i < result.Length; i++)
			{
				if (result[i] == c){
					isDuplicate = true;
					break;
				}
			}
			if(!isDuplicate){
			result+=c;
			}
			
		}
		Console.WriteLine("Modified string: "+ result);
	}
}

			
			
		
		