using System;

namespace Lesson_9.Tumakov
{
    public class Circle : Point
    {
        private double radius;

        public Circle(string color, bool isVisible, int x, int y, double radius) : base(color, isVisible, x, y)
        {
            this.radius = radius;
        }

        /// <summary>
        /// метод для вычисления площади окружности
        /// </summary>
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        /// <summary>
        /// изменение метода Display для вывода
        /// </summary>
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Радиус: {radius}");
            Console.WriteLine($"Площадь: {CalculateArea()}");
        }
    }
}
