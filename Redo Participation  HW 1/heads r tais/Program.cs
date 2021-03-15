using System;

namespace heads_r_tais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rand = new Random();
            //int toss = rand.Next(0, 2);
            //Console.WriteLine(toss);


            //Console.WriteLine(" Guess Heads or Tails!");
            //string guess = Console.ReadLine().ToLower();




            //string coin; 

            //if ( toss == 0)
            //{
            //    coin = "heads";
            //}
            //else
            //{
            //    coin = "tails";
            //}
            //if (guess.ToLower() == coin)
            //{
            //    Console.WriteLine("Congrats you guessed correctly!");
            //}

            //else
            //{
            //    Console.WriteLine("Sorry you guessed wrong");
            //}

            Console.WriteLine("Please enter a sentence");
            string sentence = Console.ReadLine().ToLower();
            int locationoffirstword = sentence.IndexOf(" ");
            string firstword = sentence.Substring(0, locationoffirstword);

            Console.WriteLine(firstword);

        }
    }
}
