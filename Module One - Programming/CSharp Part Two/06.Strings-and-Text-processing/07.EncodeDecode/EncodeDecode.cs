using System;
using System.Text;

namespace _07.EncodeDecode
{
    class EncodeDecode
    {
        static string EncodeAndDecode(string text, string cipher)
        {
            StringBuilder encodedString = new StringBuilder();

            int textIndex = 0;
            int cipherIndex = 0;

            while (textIndex < text.Length)
            {
                if (cipherIndex == cipher.Length)
                {
                    cipherIndex = 0;
                }
                encodedString.Append((char)(text[textIndex] ^ cipher[cipherIndex]));
                textIndex++;
                cipherIndex++;
            }
            return encodedString.ToString();
        }
        static void Main()
        {
            Console.Write("Insert string: ");
            string text = Console.ReadLine();
            Console.Write("Insert cipher: ");
            string cipher = Console.ReadLine();

            string encodedText = EncodeAndDecode(text, cipher);
            string decodedText = EncodeAndDecode(encodedText, cipher);

            Console.WriteLine("Encoded text: " + encodedText);
            Console.WriteLine("Decoded text: " + decodedText);
        }
    }
}
