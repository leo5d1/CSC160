using System.Net.WebSockets;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[3, 3];
            string[] pNames = { "Player 1", "Player 2" };
            char[] pSymbols = { 'X', 'O' }; // letter O

            int turn = 0;
            int totalTurns = 0;
            bool wasATie = false;


            bool quit = false;
            do
            {
                Console.WriteLine();
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        Console.WriteLine(" {0} ", board[row, col]);
                        Console.WriteLine("|");
                    }
                    Console.WriteLine("--------");
                }

                int chosenRow, chosenCol;
                bool validInput = false;
                do
                {
                    Console.WriteLine("{0} enter row (1-3)", pNames[turn]);
                    bool validRow = int.TryParse(Console.ReadLine(), out chosenRow);

                    Console.WriteLine("{0} enter column (1-3)", pNames[turn]);
                    bool validCol = int.TryParse(Console.ReadLine(), out chosenCol);

                    if (validRow && validCol)
                    {
                        validInput = true;
                        turn++;
                    }

                } while (!validInput);

                // set board sspot as owned by player
                //
                //if (CheckForWinner(board, pSymbols))
                //{
                //    break;
                //}

            } while (!quit);

            //if tie tell them
            //else tell them who won

        }

        static bool CheckForWinner(char[,] board, char pSymbols)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    int symbolsInRow = 0;
                    if (board[row, col] == pSymbols)
                    {
                        symbolsInRow++;
                    }
                    else
                    {
                        symbolsInRow = 0;
                    }
                }
            }




            return false;
        }
    }
}