using System;
class SpringSeason{
	static void Main(string[] args){
		Console.WriteLine("Enter Month ");
		int month = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Day ");
		int day = int.Parse(Console.ReadLine());
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
}

		