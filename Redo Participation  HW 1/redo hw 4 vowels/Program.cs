using System;

namespace redo_hw_4_vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a sentence>>");
            //string sentence = Console.ReadLine();
            //sentence = sentence.ToLower();

            //int vowels = 0;
            //int consonants = 0;

            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    char letter = sentence[i];

            //    if ( letter =='a' || letter == 'e' || letter =='i' || letter =='o' || letter== 'u')
            //    {
            //        vowels++;

            //    }
            //    else
            //    {
            //        consonants++;
            //    }

            //}
            //Console.WriteLine($"You have {vowels} vowels and {consonants}  consonants in the sentence!");


            Console.WriteLine("Please enter a sentence");
            string sentence = Console.ReadLine().ToLower();

            int vowels = 0;
            int consonants = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                char letter = sentence[i];

                if (letter == 'a' || letter == 'e' || letter =='i' || letter =='o'|| letter =='u')
                {
                    vowels++;
                }

                else
                {
                    consonants++;
                }
            }

            

            Console.WriteLine($"There are {vowels} vowels and {consonants} consonants in the sentence");

            string reverseword = string.Empty;
            for (int i = searchword.Length - 1; i>=0; i=i-1)
            {
                reverseword = reverseword + searchword[i];
            }

            Console.WriteLine(reverseword);

        }
    }
}
