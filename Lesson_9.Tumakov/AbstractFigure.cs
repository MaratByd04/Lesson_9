using System;

namespace Lesson_9.Tumakov
{
    public abstract class Figure
    {
        private string color;
        private bool isVisible;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public bool IsVisible
        {
            get { return isVisible; }
            set { isVisible = value; }
        }

        // Конструктор
        protected Figure(string color, bool isVisible)
        {
            this.color = color;
            this.isVisible = isVisible;
        }

        /// <summary>
        /// Метод вывода на экран
        /// </summary>
        public virtual void Display()
        {
            Console.WriteLine($"Цвет: {color}");
            Console.WriteLine($"Видимость: {(isVisible ? "Видима" : "Невидима")}");
        }
    }
}
