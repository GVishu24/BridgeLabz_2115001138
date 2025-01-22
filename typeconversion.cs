using System;
namespace Type
{
	class TypeConversion
	{
		static void Main(string[] args)
		{
		// implicit
			int x = 3;
			double y = x;
			float z = 'y';
	
			Console.WriteLine(x);
			Console.WriteLine(y);
			Console.WriteLine(z);
			
			
		// explicit
			int x1 = (int)3.5;
			double x2 = (double)3.5;
			
			Console.WriteLine(x1);
			Console.WriteLine(x2);
			
		// by methods
			float varr = Convert.ToInt32(3.21);
			Console.WriteLine(varr);
		}
	}
}
