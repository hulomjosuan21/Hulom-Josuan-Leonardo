using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Width = 10;
            r.Height = 4;
            r.CalculateArea();
            r.CalculatePerimeter();
            Console.WriteLine("Area of a Rectangle: {0}",r.Area);
            Console.WriteLine("Perimeter of a Rectangle: {0}\n",r.Perimeter);

            Square s = new Square();
            s.Side = 5;
            s.CalculateArea();
            s.CalculatePerimeter();
            Console.WriteLine("Area of a Square: {0}",s.Area);
            Console.WriteLine("Perimeter of a Square: {0}\n",s.Perimeter);

            Triangle t = new Triangle();
            t.SideA = 12;
            t.Base = 32;
            t.SideC = 5;
            t.CalculateArea();
            t.CalculatePerimeter();
            Console.WriteLine("Area of a Triangle: {0}",t.AreaT);
            Console.WriteLine("Perimeter of a Triangle: {0}\n",t.Perimeter);

            Circle c = new Circle();
            c.Radius = 23;
            c.CalculateArea();
            c.CalculatePerimeter();
            Console.WriteLine("Area of a Circle: {0}",c.Area);
            Console.WriteLine("Circumference of a Circle: {0:F2}\n", c.Circumference);
        }
    }
}