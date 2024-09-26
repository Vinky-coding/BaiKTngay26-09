using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKTdiemTP_2
{
    interface IShape
    {
        double CaculateArea();
    }
    class Circle : IShape
    {
        public double Radius { get; set; }
        public double CaculateArea() {
            return Math.PI * Radius*Radius;
        }
       
    }

    class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        
        public double CaculateArea()
        {
            return Width*Height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();

            circle.Radius = 5;
            Console.WriteLine("Area of Circle: "  + Math.Round(circle.CaculateArea(), 2));

            rectangle.Height = 50;
            rectangle.Width = 4;
            Console.WriteLine("Area of Rectangle: " + rectangle.CaculateArea());
        }
    }
}
