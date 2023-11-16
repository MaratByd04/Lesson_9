using System;

namespace Lesson_9.Tumakov
{
    /// <summary>
    /// Интерфейс для УПР 10.1: Шифрование 
    /// </summary>
    interface ICipher
    {
        string Encode(string input);
        string Decode(string input);
    }
    /// <summary>
    /// Интерфейс для ДЗ 10.1: Фигуры
    /// </summary>
    public interface IMovable
    {
        void MoveHorizontal(int distance);
        void MoveVertical(int distance);
    }

    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Упражнение 10.1\n");
            Console.ResetColor();

            ICipher aCipher = new ACipher();
            ICipher bCipher = new BCipher();

            string originalTextA = "Welcome to my cod, ladies and jentlemen!";
            string encodedTextA = aCipher.Encode(originalTextA);
            string decodedTextA = aCipher.Decode(encodedTextA);

            Console.WriteLine("Исходный текст для ACipher: " + originalTextA);
            Console.WriteLine("Зашифрованный текст ACipher: " + encodedTextA);
            Console.WriteLine("Расшифрованный текст ACipher: " + decodedTextA);

            Console.WriteLine();

            string originalTextB = "эюяё Добро пожаловать в сказочный Туссент! Город, где кровь и вино льются рекой!";
            string encodedTextB = bCipher.Encode(originalTextB);
            string decodedTextB = bCipher.Decode(encodedTextB);

            Console.WriteLine("Исходный текст для BCipher: " + originalTextB);
            Console.WriteLine("Зашифрованный текст BCipher: " + encodedTextB);
            Console.WriteLine("Расшифрованный текст BCipher: " + decodedTextB);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nДомашнее задание 10.1\n");
            Console.ResetColor();

            Point point = new Point("Красный", true, 9, 18);
            point.Display();

            Console.WriteLine();

            Circle circle = new Circle("Голубой", true, 10, 10, 7);
            circle.Display();

            Console.WriteLine();

            Rectangle rectangle = new Rectangle("Зеленый", true, 25, 12, 7, 8);
            rectangle.Display();
        }
    }

}
