using System;

namespace helloapp {
	class Rectangle {
		//member variables
		private double length;
		private double width;

		public void AcceptDetails() {
			Console.WriteLine("Enter length: ");
			length = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter width: ");
			width = Convert.ToDouble(Console.ReadLine());
		}
		public double GetArea {
			return length * width;
		}
		public void Display() {
			Console.WriteLine("Length: {0}" length);
			Console.WriteLine("Width: {0}" width);
			Console.WriteLine("Area: {0}" GetArea());
		}
	}
	//end class rectangle

	class ExecuteRectangle {
        static void Main(string[] args) {
			Rectangle r = new Rectangle();
			r.AcceptDetails();
			r.Display();
			Console.ReadLine();
        }
    }
}
