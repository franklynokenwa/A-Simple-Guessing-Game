using System;

namespace A_Simple_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secret_word = "good";
            string guessed_word = "";
            int guess_count = 0;
            int guess_limit = 3;

            do
            {
                guess_limit--;
                Console.Write("Guess a word: ");
                guessed_word = Console.ReadLine();

                if (guessed_word != secret_word)
                {
                    Console.WriteLine("You are wrong, Try Again");
                    Console.WriteLine("You have " + guess_limit + " guesses left");
                } 
                else if (guess_limit == guess_count && guessed_word != secret_word) 
                { 
                    Console.WriteLine("SORRY YOU LOSE!!!  Play Again!!!");
                    Console.ReadLine();
                }
                else
                    Console.WriteLine("\"CORRECT...  YOU WIN\"");
                    Console.ReadLine();
            }
            while (guess_limit > guess_count && guessed_word != secret_word);
            }
                      
        }
    }