using System;

namespace Documents
{
    class Numbers
    {

        //Main Function
        static void Main(string[] args)
        {
            Numbers n = new Numbers();


            n.MainInterface();
            n.game(n.NumtoGuess());


        }



        //******************************************************************
        //System Prompts
        //******************************************************************

        //This is the main interface where the user gets instructions
        private void MainInterface(){
            Console.WriteLine("Number Guessing Game \n\n" +
                "Guess the number 1-100 right in the least amount of tries to win!\n" +
                "If you ever want to quit type 'exit'");
        }


        private void WrongAnsHigher(){
            Console.WriteLine("You guessed incorrectly. \n" +
                    "The correct number is higher, try again.");
        }

        private void WrongAnsLower(){
            Console.WriteLine("You guessed incorrectly. \n" +
                    "The correct number is lower, try again.");
        }

        private void CorrectAns(int count){
            Console.WriteLine("You guessed correct! It took " + count +
                    " tries. \nGood job!");
        }


        //******************************************************************
        //Technical Functions
        //******************************************************************

        //Creates the random number to be guessed
        private int NumtoGuess(){
            Random random = new Random();

            return random.Next(100);
        }


        //The game putting the functions together
        private void game(int correctNum){   
            Numbers n = new Numbers();
            bool correct = false;
            int count = 1;


            //Makes a loop for the game
            while (correct == false){
                Console.WriteLine("Guess " + count);
                string guess = Console.ReadLine();


                //If the user prompts to exit the program will stop
                if (guess == "exit"){
                    Console.WriteLine("Thank you for playing");
                    System.Environment.Exit(1);

                } 


                //Makes guess into an int and checks to see where the guess lies
                try{
                        if (Int16.Parse(guess) == correctNum){
                            n.CorrectAns(count);
                            break;
                        } else if (Int16.Parse(guess) > correctNum) {
                            n.WrongAnsLower();
                        } else if (Int16.Parse(guess) < correctNum){
                            n.WrongAnsHigher();
                        }
                        
                }catch{
                        Console.WriteLine("That is not a valid answer, Try again");
                    }
                
                count++; 

            }

        }







    }
}
