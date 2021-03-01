using System;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "tAylOr SwIFT, tHe WeEknD, TRaVis sCoTt, aRiANa gRAnE, bILLiE eiLiSH";

            string newMessage = message.ToUpper()[O] + message.ToLower().Substring(1);

            string[ ] artists = message.Split(',');

            for (int i = 0; 1 < artists.Length; i++)
            {
                string artist = artists[i].Trim;

                string[] names = artist.Split(' ');
                string firstName = names[0];
                string lastName = names[1];


                string newArtist = firstName.ToUpper()[O] + firstName.ToLower().Substring(1);
                                  lastName.ToUpper()[O] + lastName.ToLower().Substring(1);

                Console.WriteLine(artiss[i]);
            }

            Console.WriteLine(newMessage);
         
        }
    }
}
