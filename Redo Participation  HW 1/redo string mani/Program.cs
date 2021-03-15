using System;

namespace redo_string_mani
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string message = ("Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.");
            Console.WriteLine(message);

            Console.WriteLine("What word would you like to search for?");
            string searchword = Console.ReadLine();

            Console.WriteLine("What word you like to change it too");
            string changeword = Console.ReadLine();

            if (message.Contains(searchword)==false)
            {
                Console.WriteLine($"Sorry your word {searchword} was not found");
            }
            else
            {
                 string newmessage = message.Replace(searchword, changeword);
                Console.WriteLine(newmessage);
            }

            string reverseword = string.Empty;
            for (int i =  searchword.Length -1; i>=0; i= i-1)
            {
                reverseword = reverseword + searchword[i];
                
            }
            Console.WriteLine(reverseword);

        }
    }
}
