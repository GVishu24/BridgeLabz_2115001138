using System;
class SpringSeason{
	public void CheckSeason(int month, int day){
		 // Check if the input is valid
		if (month < 1 || month > 12 || day < 1 || day > 31)
            {
				Console.WriteLine("Please enter a valid month and day.");
				return;
			
            }
			
		if ((month == 3 && day >= 20) || (month > 3 && month < 6) || (month == 6 && day <= 20)){
			Console.WriteLine("It is a spring season");
		}
		else{
			Console.WriteLine("Not a spring season");
		}
	}
	static void Main(string[] args){
		Console.WriteLine("please enter month: ");
		int month = int.Parse(Console.ReadLine());
		Console.WriteLine("please enter day: ");
		int day = int.Parse(Console.ReadLine());
		SpringSeason ss = new SpringSeason();
		ss.CheckSeason(month, day);
	}
}
		
		