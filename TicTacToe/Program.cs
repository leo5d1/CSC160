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

            bool quit = false;
            do
            {
                Console.WriteLine();
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        Console.Write(" {0} ", board[row, col]);
                        if (col < board.GetLength(1) - 1)
                        {
                            Console.Write("|");
                        }
                    }
                    Console.WriteLine();
                    if (row < board.GetLength(1) - 1)
                    {
                        Console.WriteLine("--------");
                    }
                    
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
                    }

                    if (pNames[turn] == "Player 1")
                    {
                        totalTurns++;
                        turn++;
                    }
                    else
                    {
                        totalTurns++;
                        turn--;
                    }

                } while (!validInput);

                // set board spot as owned by player
                board[chosenRow - 1, chosenCol - 1] = pSymbols[turn];

                // check for winner
                if (CheckForWinner(board, pSymbols[turn]))
                {
                    break;
                }
                // check for tie
                if (totalTurns == 9)
                {
                    break;
                }

            } while (!quit);

            Console.WriteLine();
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    Console.Write(" {0}  ", board[row, col]);
                    if (col < board.GetLength(1) - 1)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                if (row < board.GetLength(1) - 1)
                {
                    Console.WriteLine("--------");
                }
            }

            // End of Game
            if (totalTurns == 9)
            {
                Console.WriteLine("Game Over.");
                Console.WriteLine("You Tied!");
            }
            else
            {
                if (turn == 0)
                {
                    Console.WriteLine("{0} has won!", pNames[1]);
                }
                else
                {
                    Console.WriteLine("{0} has won!", pNames[0]);
                }    
            }
            

        }

        static bool CheckForWinner(char[,] board, char pSymbol)
        {
            
            for (int row = 0; row < board.GetLength(0); row++)
            {
                int symbolsInRow = 0;
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col] == pSymbol)
                    {
                        symbolsInRow++;
                        if (symbolsInRow == 3)
                        {
                            return true;
                        }
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