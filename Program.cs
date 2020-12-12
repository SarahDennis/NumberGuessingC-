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


        private void WrongAns(){
            Console.WriteLine("You guessed incorrectly, try again");
        }

        private void CorrectAns(){
            Console.WriteLine("You guessed correct! Good job");
        }


        //******************************************************************
        //Technical Functions
        //******************************************************************

        //Creates the random number to be guessed
        private int NumtoGuess(){
            Random random = new Random();

            return random.Next(188);
        }








    }
}
