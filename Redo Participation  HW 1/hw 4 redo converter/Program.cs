using System;

namespace hw_4_redo_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a sentence>>");
            string sentence = Console.ReadLine().ToLower();
            sentence = sentence.Replace("A", "4")
                             .Replace("E", "3")
                             .Replace("H", "|-|")
                             .Replace("S", "$")
                             .Replace("T", "7")
                             .Replace("U", "|_|")
                             .Replace("O", "0")
                             .Replace("P", "[]D");

            if (sentence[sentence.Length - 1] != '!') ;
            {
                sentence = sentence + "!";
            }

            Console.WriteLine(sentence);

        }
    }
}
