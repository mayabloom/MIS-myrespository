using System;

namespace redo_participation_4__string_manipuaton
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = ("Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.");
            Console.WriteLine($"{ message}");

            Console.WriteLine("What word would you like to search for?");
            string searchword = Console.ReadLine();

            Console.WriteLine("What world you like to change?");
            string change = Console.ReadLine();

            if (message.Contains(searchword) == true)
            {
                string newmessage = message.Replace(searchword, change);
                Console.WriteLine(newmessage);
            }
            else
            {
                Console.WriteLine($"Sorry I couldn't find your word {searchword}");
            }

            string reverseword = string.Empty;
            for (int i = searchword.Length -1; i>=0; i=i-1)
            {
                reverseword = reverseword + searchword[i];
                
            }
            Console.WriteLine(reverseword);

        }
    }
}
