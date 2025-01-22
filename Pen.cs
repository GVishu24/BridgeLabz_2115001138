using System;
class Pen{
	int totalPen = 14;
	int totalStudent= 3;
	//function to calculate pen per student
	public void calPenPerStudent(){
		int penPerStudent = totalPen / totalStudent;
		int remainingPen = totalPen % totalStudent;
		Console.WriteLine(string.Format("The Pen Per Student is {0} and the remaining pen not distributed is {1}",penPerStudent,remainingPen));
	}
	// main function
	static void Main(string[] args){
		//creating object to call the instance
		Pen penobj = new Pen();
		penobj.calPenPerStudent();
	}
}

		