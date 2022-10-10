using System;

namespace ProgChallengeStart
{
    class Program{
        static void Main(string[] args)
        {
            // choose a number between 0 and 20
            int theNumber = new Random().Next(20);
            bool keepGoing = false;
            int count = 0;
            int targetNum = 0;
            //print game greeting and instructions
            Console.WriteLine("let's play 'Guess the Number!!'");
            Console.WriteLine("I'm thinking of a number between 0 and 20");
            Console.WriteLine("Enter your guess, or -1 to give up");

            string guess = Console.ReadLine();
            keepGoing = int.TryParse(guess, out targetNum);
            
           while(targetNum != theNumber){
            guess = Console.ReadLine();
            keepGoing = int.TryParse(guess, out targetNum);
            if(keepGoing){
                count++;
                if(targetNum < theNumber){
                    Console.WriteLine("Nope, higher than that.");
                    Console.WriteLine("What's your guess?");
                }
                else if(targetNum > theNumber){
                    Console.WriteLine("Nope, lower than that.");
                    Console.WriteLine("What's your guess?");
                }
                else{
                    Console.WriteLine($"You got it in {count} guesses!!");
                    break;
                }
                
            }else{
                Console.WriteLine("Hmmm, that doesn't look like a number. Try again.");
                Console.WriteLine("What's your guess?");
            }

           }
        }
    }
}