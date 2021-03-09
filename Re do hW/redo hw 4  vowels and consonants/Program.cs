using System;

namespace redo_hw_4__vowels_and_consonants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence >>");
            string sentence = Console.ReadLine();
            sentence = sentence.ToLower();

            int vowels = 0, consonants = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                char letter = sentence[i];
                if (letter == 'a' || letter == 'i' || letter == 'o' || letter == 'e' || letter == 'u')
                {
                    vowels++;
                }

                else if (letter == ' ' || letter =='?' || letter == ':' )
                {

                }

                else
                {
                    consonants++;
                }

                Console.Writeline($"There are {vowels.ToString("g0")} in the sentence");
                Console.WriteLine($"There are {consonants.ToString("g0")} in the sentence");
            }





        }
    }
}
