using System;
class Vote{
	static void Main(string[] args){
		int[] ages = new int[10];
		Console.WriteLine("Enter ages of 10 students: ");
		for (int i = 0; i < ages.Length; i++ ){
			ages[i]= int.Parse(Console.ReadLine());
		}
		Console.WriteLine("Eligiblity:");
		foreach(int age in ages){
			if (age >= 18){
				Console.WriteLine("Eligible");
			}
			else{
				Console.WriteLine("Not Eligible");
			}
		}
	}
}
				