using System;

namespace Lesson_9.Tumakov
{
    class BCipher : ICipher
    {
        public string Encode(string input)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    char baseChar = char.IsUpper(input[i]) ? 'А' : 'а';
                    int position = input[i] - baseChar;
                    int newPosition = ('Я' - baseChar) - position;
                    result[i] = (char)(baseChar + newPosition);
                }
                else
                {
                    result[i] = input[i];
                }
            }

            return new string(result);
        }

        public string Decode(string input)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    char baseChar = char.IsUpper(input[i]) ? 'А' : 'а';
                    int position = ('Я' - baseChar) - (input[i] - baseChar);
                    result[i] = (char)(baseChar + position);
                }
                else
                {
                    result[i] = input[i];
                }
            }

            return new string(result);
        }
    }
}
