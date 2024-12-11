using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher2._0
{
    internal class Decode
    {
        public static string decode(string text, int k)
        {
            char[] chars = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    char encodedLetter = (char)(text[i] - k);

                    if (char.IsLower(text[i]) && encodedLetter < 'a')
                    {
                        encodedLetter = (char)(encodedLetter + 26);
                    }
                    else if (char.IsUpper(text[i]) && encodedLetter < 'A')
                    {
                        encodedLetter = (char)(encodedLetter + 26);
                    }
                    chars[i] = encodedLetter;
                }
                else
                {
                    chars[i] = text[i];
                }
            }

            string decodedText = new string(chars);

            return decodedText;
        }
    }
}
