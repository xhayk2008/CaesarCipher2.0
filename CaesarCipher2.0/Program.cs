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

            string EncodedCode = Encode.encode(text, key);

            string DecodedCode = Decode.decode(EncodedCode, key);

            Console.WriteLine();

            Console.WriteLine($"Encoded Text: {EncodedCode}");
            Console.WriteLine($"Decoded Text: {DecodedCode}");
        }
    }
}
