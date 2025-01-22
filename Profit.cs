using System;
class Program{
	static void calculateProfit(int costPrice, int sellPrice){
		double profit = (sellPrice - costPrice);
		double profitper = (profit/costPrice)*100;
		Console.WriteLine("The Cost Price is INR" + costPrice + "and Selling Price is INR" + sellPrice + "\n The Profit is INR" + profit+ "and the Profit Percentage is " + profitper);
	}
	static void Main(string[] args){
		//int costPrice = 129;
		//int sellPrice = 191;
		//double res = 
		Program.calculateProfit(129,191);
	}
}
	