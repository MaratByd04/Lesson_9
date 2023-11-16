namespace Lesson_9.Tumakov
{
    public class ACipher : ICipher
    {
        public string Encode(string input)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    char baseChar = char.IsUpper(input[i]) ? 'A' : 'a';
                    result[i] = (char)((input[i] - baseChar + 1) % 26 + baseChar);
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
                    char baseChar = char.IsUpper(input[i]) ? 'A' : 'a';
                    result[i] = (char)((input[i] - baseChar - 1 + 26) % 26 + baseChar);
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
