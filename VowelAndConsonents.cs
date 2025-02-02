using System;
class VowelAndConsonents{
	static void Main(string[] args){
		Console.WriteLine("Enter a string: ");
		string text = Console.ReadLine();
		int vCount = 0;
		int cCount = 0;
		text = text.ToLower();
		foreach(char c in text){
			if (char.IsLetter(c)){
				if (c == 'a' || c == 'e' || c == 'i'|| c == 'o'|| c == 'u'){
					vCount++;
				}
				else{
					cCount++;
				}
			}
			else{
				Console.WriteLine("Enter a valid string");
			}
		}
		Console.WriteLine("Vowel count = " + vCount);
		Console.WriteLine("Consonent count = " + cCount);
	}
}

			
				
			
