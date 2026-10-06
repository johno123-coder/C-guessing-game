using System;

namespace GuessingGame;

    class Program
    {
        static void Main(string[] args)
    {
         Random random = new Random();
          int  numberToGuess = random.Next(1,10);
             int numberOfGuesses = 0;
             int myguess = 0;
            while (myguess != numberToGuess)
            {
                
                
                Console.WriteLine("Please guess a number between 1 and 10 ");
         
            
string? input = Console.ReadLine();
if (!int.TryParse(input, out myguess))
                {
                    System.Console.WriteLine("that is not a number");
                    continue;
                }
                numberOfGuesses++;

   if (numberOfGuesses == 6 && myguess != numberOfGuesses)
            {
                System.Console.WriteLine($"You lose! The number was {numberToGuess}");
                break;
            }
          if (myguess > numberToGuess)
                {
                    Console.WriteLine("Your guess is too high");
                }else if(myguess < numberToGuess)
                {
                     
                     
                    Console.WriteLine("Your guess is too low");
                }
                else
            {

                
                System.Console.WriteLine($"You win! You got it in {numberOfGuesses} guesses");
                            }
    }
    }
    }
    
