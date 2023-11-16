using System;

namespace Lesson_9.Tumakov
{
    public class Point : Figure, IMovable
    {
        private int x;
        private int y;

        // конструктор 
        public Point(string color, bool isVisible, int x, int y) : base(color, isVisible)
        {
            this.x = x;
            this.y = y;
        }

        // реализовал методы интерфейса 
        public void MoveHorizontal(int distance)
        {
            x += distance;
        }

        public void MoveVertical(int distance)
        {
            y += distance;
        }

        // изменил метод Display для задачи
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Позиция: ({x}, {y})");
        }
    }
}
