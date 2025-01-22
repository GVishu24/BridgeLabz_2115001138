using System;
namespace Input
{
	class TakingInput
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			Console.WriteLine("Hello " + name);
			Console.WriteLine(name + " how many apples do you want");
			string apple = Console.ReadLine();
			Console.WriteLine(name + " you will get 2 more apples " + (Convert.ToInt64(apple) + 2));
		}
	}
}