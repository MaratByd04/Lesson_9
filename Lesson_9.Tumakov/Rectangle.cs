using System;

namespace Lesson_9.Tumakov
{
    public class Rectangle : Point
    {
        private double width;
        private double height;

        public Rectangle(string color, bool isVisible, int x, int y, double width, double height) : base(color, isVisible, x, y)
        {
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// метод для вычисления площади прямоугольника
        /// </summary>
        public double CalculateArea()
        {
            return width * height;
        }

        /// <summary>
        /// метод Display
        /// </summary>
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Ширина: {width}");
            Console.WriteLine($"Высота: {height}");
            Console.WriteLine($"Площадь: {CalculateArea()}");
        }
    }
}
