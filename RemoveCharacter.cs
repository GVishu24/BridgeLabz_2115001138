using System;
class RemoveCharacter{
	static string RemoveChar(string input, char charToRemove){
		string result = "";
		foreach (char c in input){
			if (c != charToRemove){
				result += c;
			}
		}
		return result;
	}
	static void Main(string[] args){
		Console.WriteLine("Enter a string: ");
		string input = Console.ReadLine();
		
		Console.WriteLine("Enter character to remove: ");
		char charToRemove = Console.ReadLine()[0]; // [0]: to take single char as input
		
		string modified = RemoveChar(input, charToRemove);
		Console.WriteLine("Modified string: "+ modified);
	}
}

		