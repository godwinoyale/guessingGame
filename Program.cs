using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of some variables
            int chancesEasy = 6;
            int chancesMedium = 4;
            int chancesHard = 3;
            int difficulty = 0;
            Random rand = new Random();
            int easy = rand.Next(1, 10);
            int medium = rand.Next(1, 20);
            int hard = rand.Next(1, 50);
            int guesses = 0; 

            Console.WriteLine("Please select the level you wish to play: 1-easy, 2-medium and 3-hard");
            Console.Write("Difficulty Level: ");
            difficulty = int.Parse(Console.ReadLine());

            if(difficulty == 1){
                for(int i = 0; i < chancesEasy; i++){
                    int guessesLeft = 5 -i;
                    Console.Write("Guess the number between 1 -10: ");

                    guesses = int.Parse(Console.ReadLine());
                    if(guesses != easy){
                        Console.WriteLine("That was wrong!");
                        Console.WriteLine("You have " + guessesLeft + " chances left." );
                        if(guessesLeft == 0){
                            Console.WriteLine("Game Over!");
                        }
                    }else{
                        Console.WriteLine("You got it right!");
                        break;
                    }
                }
            }else if(difficulty == 2){
                for(int i = 0; i < chancesMedium; i++){
                    int guessesLeft = 3 -i;
                    Console.WriteLine("Guess the number between 1 - 20: ");

                    guesses = int.Parse(Console.ReadLine());
                    if(guesses != medium){
                        Console.WriteLine("That was wrong!");
                        Console.WriteLine("You have " + guessesLeft + " chances left.");
                        if(guessesLeft == 0){
                            Console.WriteLine("Game Over!");
                            
                        }
                    }else {
                        Console.WriteLine("You got it right!");
                        break;

                    }
                }
            }else if(difficulty == 3){
                for(int i = 0; i < chancesHard; i++){
                    int guessesLeft = 2 - 1;
                    Console.WriteLine("Guess the number between 1 - 50: ");

                    guesses = int.Parse(Console.ReadLine());
                    if(guesses != hard){
                        Console.WriteLine("That was wrong!");
                        Console.WriteLine("You have " + guessesLeft + " chances left.");
                        if(guessesLeft == 0){
                            Console.WriteLine("Game Over!");
                        }
                    }else {
                        Console.WriteLine("You got it right!");
                        break;
                    }
                }
            }else{
                Console.Write("Please select a level of difficulty to play: 1-easy, 2-medium and 3-hard");
            }
        }
    }
}
