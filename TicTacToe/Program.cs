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

            int chosenRow, chosenCol;
            bool rowInput = false, colInput = false;
            bool validRow, validCol;
            bool validInput = false;

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

                do
                {
                    do
                    {
                        Console.WriteLine("{0} Enter Row (1-3): ", pNames[turn]);
                        validRow = int.TryParse(Console.ReadLine(), out chosenRow);

                        if (chosenRow <= 3 && chosenRow >= 1)
                        {
                            rowInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Row. Try again.");
                        }
                    } while (!rowInput);

                    do
                    {
                        Console.WriteLine("{0} enter column (1-3)", pNames[turn]);
                        validCol = int.TryParse(Console.ReadLine(), out chosenCol);

                        if (chosenCol <= 3 && chosenCol >= 1)
                        {
                            colInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Column. Try again.");
                        }
                    } while (!colInput);

                    if (rowInput && colInput)
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
            // check for 3 in row
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

            // check for 3 in column
            for (int col = 0; col < board.GetLength(1); col++)
            {
                int symbolsInCol = 0;
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    if (board[row, col] == pSymbol)
                    {
                        symbolsInCol++;
                        if (symbolsInCol == 3)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        symbolsInCol = 0;
                    }
                }
            }

            // check for 3 in left to right diagonall
            int ltrWin = 0;
            if (board[0,0] == pSymbol)
            {
                ltrWin++;
                if (board[1, 1] == pSymbol)
                {
                    ltrWin++;
                    if (board[2, 2] == pSymbol)
                    {
                        ltrWin++;
                        if (ltrWin == 3)
                        {
                            return true;
                        }
                    }
                }
            }

            // check for 3 in right to left diagonall
            int rtlWin = 0;
            if (board[0, 2] == pSymbol)
            {
                rtlWin++;
                if (board[1, 1] == pSymbol)
                {
                    rtlWin++;
                    if (board[2, 0] == pSymbol)
                    {
                        rtlWin++;
                        if (rtlWin == 3)
                        {
                            return true;
                        }
                    }
                }
            }


            return false;
        }
    }
}