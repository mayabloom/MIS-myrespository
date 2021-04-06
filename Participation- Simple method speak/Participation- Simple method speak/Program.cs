using System;

namespace Participation__Simple_method_speak
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal;
            string answer;
            do
            {
                Console.WriteLine("What animal would you like to hear the sound for?  ");
                animal = Console.ReadLine().ToLower();

                string sound = Speak(animal);
                Console.WriteLine($" A {animal} makes the sound of {sound} ");

                Console.WriteLine("Do you want to hear another sound of an animal? Yes or No ??");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y') ;
        }
        /// <summary>
        /// Returning the sound of an animal given the animal
        /// </summary>
        /// <param name="anyVariableAnimals"> The sound we want to give to the animal</param>
        /// <returns>A string that is the sound of the animal. A random sound if the animal is not included. </returns>
        static string Speak (string anyVariableAnimals)
        {

            string animalsound;

            if (anyVariableAnimals == "dog")
            {
                animalsound = "Ruff";
            }
            else if ( anyVariableAnimals == "goat")
            {
                animalsound = " Bahhhh";
            }
            else if (anyVariableAnimals == "monkey")
            {
                animalsound = " OOO AH AH";
            }
            else
            {
                animalsound = "EEE AHHH ";
            }

            return animalsound;

        }
    }
}
