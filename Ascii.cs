using System;
class Ascii{
	static void Main (string[] args){
		string text = "AaBc";
		Console.WriteLine("character and their ASCII Value: ");
		foreach(char c in text){
			Console.WriteLine(c + "=" + (int)c);
		}
	}
}
		