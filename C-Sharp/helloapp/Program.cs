using System;

namespace RectangleApplication {
    class Rectangle{
        //member variables
        double length;
        double width;
        double d;
        int i;
        public void Acceptdetails() {
            length = 4.5;
            width = 3.5;
            d = 5673.74;
            // cast double to int
            i = (int)d;
        }
        public double GetArea() {
            return length * width;
        }
        public void Display() {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.WriteLine(i);
        }
    }
    class ExecuteRectangle {
        static void Main(string[] args) {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadKey();
        }
    }
}
/* This program demonstrates
The basic syntax of C# programming 
Language */