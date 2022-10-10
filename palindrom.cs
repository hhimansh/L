// Rules :
// Program reads input and determines if the string is plindrome
// Must ignore case and punctuation
// function must be named IsPalindrome
// returns 2 values : boolean and integer
// runs until exit is typed

using System;

namespace ProgChallenge
{
    class Program
    {
        static void Main(string[] arg){
            Console.WriteLine("Let's begin: ");
            string refer = "";
            string guess = Console.ReadLine();
            guess = guess.ToLower();
            while(guess != "exit"){
                for(int i=0; i<guess.Length; i++){
                    if(guess[i] >= 'a' && guess[i] <= 'z'){
                        refer += guess[i];
                    }
                }
                // Console.WriteLine($"refer: {refer}");
                (bool, int) result = IsPalindrome(refer);
                if(result.Item1 == true){
                    Console.WriteLine($"Plaindrome: {result.Item1}, Length: {guess.Length}");
                }
                else{
                    Console.WriteLine($"Plaindrome: {result.Item1}, Length: {0}");
                }
                
                guess = Console.ReadLine();
                guess = guess.ToLower();
                refer = "";
            }
            if(guess == "exit")
            {
                Environment.Exit(0);
            }
        }
        static(bool, int) IsPalindrome(string input){
            string opposite = "";
            for(int i=input.Length-1; i>=0; i--){
                opposite += input[i];
            }
            // Console.WriteLine($"opposite: {opposite}");
            if(opposite.Equals(input)){
                return(true, input.Length);
            }else{
                return(false, 0);
            }
        }
    }
}