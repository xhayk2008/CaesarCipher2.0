namespace CaesarCipher2._0
{
    class Encode
    {
        public static string encode(string text, int k)
        {
            char[] chars = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    char encodedLetter = (char)(text[i] + k);

                    if (char.IsLower(text[i]) && encodedLetter > 'z')
                    {
                        encodedLetter = (char)(encodedLetter - 26);
                    }
                    else if (char.IsUpper(text[i]) && encodedLetter > 'Z')
                    {
                        encodedLetter = (char)(encodedLetter - 26);
                    }
                    chars[i] = encodedLetter;
                }
                else
                {
                    chars[i] = text[i];
                }
            }

            string encodedText = new string(chars);

            return encodedText;
        }
    }
}
