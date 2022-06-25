using System;
namespace Assignment6
{
    class Program // Program class
    {
        abstract class Shape
        {
            public double width;
            public double height;
            public virtual double CalculateSurface() {
                return 0;
            }
        }
// Rectangle class
        class Rectangle : Shape
        {
            public override double CalculateSurface()
            {
                return height * width;
            }
        }
        class Triangle : Shape
        {
// Triangle class
            public override double CalculateSurface()
            {
                return height * width / 2;
            }
        }
        class Circle : Shape
        {
// Circle class
            public Circle(double radius)
            {
                this.height = radius;
                this.width = radius;
            }
// Circle class
            public override double CalculateSurface()
            {
                return Math.PI * height * width;
            }
        }
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Rectangle();
            shapes[0].height = 5;
            shapes[0].width = 4;
            shapes[1] = new Triangle();
            shapes[1].height = 5;
            shapes[1].width = 4;
            shapes[2] = new Circle(5);

            for (int i = 0; i < 3; i++) {
                Console.WriteLine("Surface: {0}", shapes[i].CalculateSurface());
            }
                Console.ReadLine();// Reads the console
        }
    }// End of Program class
}// End of namespace Assignment6 @DASLAW