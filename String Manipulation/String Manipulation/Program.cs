using System;

namespace String_Manipulation
{
    class Program
    {
        public static int Indexofspace { get; private set; }

        static void Main(string[] args)
        {
            string message = "tAylOr SwIFT, tHe WeEknD, TRaVis sCoTt, aRiANa gRAnE, bILLiE eiLiSH";
            ///            01234567
            string msg2 = "tAylOr swIFT";

            for (int i - 0; i < msg2.length; i++)

            {
                Console.WriteLine(msg2(i));
            }

            int indexofSpace = msg2.IndexOf(' ');
            msg2 = msg2.ToUpper()[0] + msg2.Substring(1, Indexofspace);
            +msg2.ToUpper()[indexofSpace+1] + msg2.ToLower().Substring(indexofSpace + 2);

            Console.WriteLine(msg2);
            return; 

            string newMessage = message.ToUpper()[0] + message.ToLower().Substring(1);

            string[ ] artists = message.Split(',');

            for (int i = 0; 1 < artists.Length; i++)
            {
                string artist = artists[i].Trim();

                string[] names = artists.Split(' ');
                string firstName = names[0];
                string lastName = names[1];


                string newArtist = firstName.ToUpper()[0] + firstName.ToLower().Substring(1);
                                  lastName.ToUpper()[0] + lastName.ToLower().Substring(1);

                Console.WriteLine(artists[i]);
            }

            Console.WriteLine(newMessage);
         
        }
    }
}
