using System;
using System.Collections.Generic;
using MasterMindLibrary;


namespace MasterMind
{
    class Program
    {
        static List<Peg> pegList = new List<Peg>()
        {
            new Peg(ConsoleColor.White, ConsoleColor.Red),
            new Peg(ConsoleColor.White, ConsoleColor.Blue),
            new Peg(ConsoleColor.Black, ConsoleColor.Green),
            new Peg(ConsoleColor.Black, ConsoleColor.Yellow),
            new Peg(ConsoleColor.Black, ConsoleColor.Cyan),
            new Peg(ConsoleColor.White, ConsoleColor.Magenta),
            new Peg(ConsoleColor.White, ConsoleColor.DarkGray),
            new Peg(ConsoleColor.White, ConsoleColor.DarkRed)
        };

        static void Main(string[] args)
        {
            List<Attempt> allAttempts = new List<Attempt>();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to Mastermind!");
            Console.ResetColor();

            //ask for difficulty
            int intDifficulty = MMLib.GetConsoleMenu(new List<string> { "Easy - 4 pegs", "Medium - 6 pegs", "Hard - 8 pegs" });

            //ask for maxTurns of turns to guess it
            int maxTurns = MMLib.GetConsoleInt("How many attempts (1 - 50) ", 1, 50);

            //store the maxPegs based on difficulty
            int maxPegs = 2 + (intDifficulty * 2);

            //Generate an answer
            List<int> answer = MMLib.GenerateAnswer(maxPegs);

            //show cheat? 
            MMLib.Cheat(answer, pegList);

            //loop while !gameWon && maxTurns != 0
            bool gameWon = false;
            while(!gameWon && maxTurns != 0)
            {
                //get user attempt
                Attempt attempt = GetAttemptFromUser(maxPegs, allAttempts, maxTurns);

                //Check the attempt for a correct guess
                CheckAttempt(attempt, answer);

                //add the attempt to the attempt list
                allAttempts.Add(attempt);

                //determin if the game has been won or not
                if(attempt.CorrectAnswerCount == maxPegs)
                {
                    gameWon = true;
                }

                //reduce the maxTurns
                maxTurns--;


            }

            //If won, display Game Won!
            if (gameWon == true)
            {
                Console.WriteLine("Game Won!");
                MMLib.ShowAnswer(answer, pegList, "0");
            }
            //If lost, show game loss
            //show the correct answer
            if (gameWon == false && maxTurns == 0)
            {
                Console.WriteLine("You Lost.");
                MMLib.ShowAnswer(answer, pegList, "0");
            }
        }

        static Attempt GetAttemptFromUser(int maxPegs, List<Attempt> allAttempts, int maxTurns)
        {
            //Create a new Attempt
            Attempt attempt = new Attempt();

            //Get color options based on maxPegs
            MMLib.GetColorOptions(maxPegs, pegList);
            
            //Loop of # of pegs they need to choose
            for (int i = 0; i < maxPegs; i++)
            {
                //clear console
                Console.Clear();

                //Display # of attempts left
                Console.WriteLine("Number of attempts left: {0}", maxTurns);

                //Show all previous attempts
                MMLib.ShowAttempts(allAttempts, pegList, "0");

                //Show pegs they have chosen already in this attempt
                MMLib.ShowChosenPegs(attempt, pegList);

                //Ask them to pick a peg color from a menu of options
                int chosenPeg = MMLib.GetConsoleMenu(MMLib.GetColorOptions(maxPegs, pegList)) - 1;

                //Add the chosen peg to the Attempt.AtemptList
                attempt.AttemptList.Add(chosenPeg);
            }
            //Return the attempt when done
            return attempt;
        }


        static void CheckAttempt(Attempt attempt, List<int> answer)
        {
            //Check the attempt.AttemptList to see if they got a match to the answer
            //If a peg is correct, increment the attempt.CorrectAnswerCount
            for (int i = 0; i < answer.Count; i++)
            {
                if (attempt.AttemptList[i] == answer[i])
                {
                    attempt.CorrectAnswerCount++;
                }
            }
        }
    }
}
