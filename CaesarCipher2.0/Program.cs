namespace CaesarCipher2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Text: ");
            string text = Console.ReadLine() ?? String.Empty;

            Console.Write("Key: ");
            bool converting = int.TryParse(Console.ReadLine(), out int key);

            ConsoleKey consolekey = Console.ReadKey().Key;

            switch (consolekey)
            {
                case ConsoleKey.E:
                    Console.Clear();
                    string EncodedCode = Encode.encode(text, key);
                    Console.WriteLine($"Encoded Text: {EncodedCode}");
                    break;
                case ConsoleKey.D:
                    Console.Clear();
                    string DecodedCode = Decode.decode(text, key);
                    Console.WriteLine($"Decoded Text: {DecodedCode}");
                    break;
            }
        }
    }
}
