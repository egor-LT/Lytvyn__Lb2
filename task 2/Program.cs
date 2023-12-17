using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Point
    {
        
        private double x;
        private double y;
        private string name;

        
        public Point(double x, double y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        
        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }
    }

    class Figure
    {
        
        private Point[] points;

        
        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[] { p1, p2, p3 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[] { p1, p2, p3, p4 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[] { p1, p2, p3, p4, p5 };
        }

        
        public double GetSideLength(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        
        public void CalculatePerimeter()
        {
            double perimeter = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += GetSideLength(points[i], points[i + 1]);
            }

            perimeter += GetSideLength(points[points.Length - 1], points[0]);

            Console.WriteLine($"Периметр багатокутника: {perimeter}");
        }
    }

    class Program
    {
        static void Main()
        {
            
            Point point1 = new Point(0, 0, "A");
            Point point2 = new Point(0, 4, "B");
            Point point3 = new Point(3, 0, "C");

            Figure triangle = new Figure(point1, point2, point3);

            
            triangle.CalculatePerimeter();

            Console.ReadKey();
        }
    }
}