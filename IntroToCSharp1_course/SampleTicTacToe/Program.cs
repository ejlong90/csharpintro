namespace SampleTicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> board = new List<List<string>>();
            bool isGameOver = false;

            //building empty board
            board.Add(new List<string> { "0", "1", "2" });
            board.Add(new List<string> { "3", "4", "5" });
            board.Add(new List<string> { "6", "7", "8" });
            PrintBoard(board);

            while (!isGameOver)
            {
                //ask for position to place on board
                Console.WriteLine("Enter a board Position! ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                //Users move and placement
                CheckAndPlacePosition(userInput, true);

                //Computers mover and placement
                int computerInput = GetComputerMove();
                CheckAndPlacePosition(computerInput);

            }

            void PrintBoard(List<List<string>> incBoard)
            {
                Console.Clear();
                for (int item = 0; item < incBoard.Count; item++)
                {
                    Console.WriteLine("{0} | {1} | {2}", board[item][0], board[item][1], board[item][2]);
                    if (item != incBoard.Count - 1)
                        Console.WriteLine("----------");
                }
            }

            void CheckAndPlacePosition(int pos, bool isUser = false)
            {
                int boardRow = 0;
                int boardCol = 0;
                //check if position is available
                if (Enumerable.Range(0, 3).Contains(pos)) { boardRow = 0; boardCol = pos; }
                else if (Enumerable.Range(3, 3).Contains(pos)) { boardRow = 1; boardCol = pos - 3; }
                else if (Enumerable.Range(6, 3).Contains(pos)) { boardRow = 2; boardCol = pos - 6; }
                //If position isnt in range ask for new position
                else
                {
                    Console.WriteLine("Enter valid number");
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    if (!isUser)
                    {
                        CheckAndPlacePosition(GetComputerMove());
                    }
                    else
                    {
                        //if position isnt valid ask for new one and start method over
                        CheckAndPlacePosition(userInput, isUser);
                    }
                }

                //check if position is taken if not place X or O
                if (board[boardRow][boardCol] != "X" && board[boardRow][boardCol] != "O")
                {
                    if (isUser) board[boardRow][boardCol] = "X";
                    else board[boardRow][boardCol] = "O";
                }
                else
                {
                    if (!isUser)
                    {
                        CheckAndPlacePosition(GetComputerMove());
                    }
                    else
                    {
                        //if position isnt valid ask for new one and start method over
                        Console.WriteLine("Enter Unused space");
                        int userInput = Convert.ToInt32(Console.ReadLine());
                        CheckAndPlacePosition(userInput, isUser);
                    }
                }
                //Is this a winning move
                CheckGameOver();
                PrintBoard(board);
            }

            int GetComputerMove()
            {
                Random rnd = new Random();
                return rnd.Next(8);
            }

            bool CheckGameOver()
            {
                List<List<List<string>>> winBoardsX = new List<List<List<string>>>()
    {
        new List<List<string>>()
        {
            new List<string>(){"X","X","X"},
            new List<string>(){" "," "," "},
            new List<string>(){" "," "," "}
        },
        new List<List<string>>()
        {
            new List<string>(){" "," "," "},
            new List<string>(){"X","X","X"},
            new List<string>(){" "," "," "}
        },
        new List<List<string>>()
        {
            new List<string>(){" "," "," "},
            new List<string>(){" "," "," "},
            new List<string>(){"X","X","X"}
        },
        new List<List<string>>()
        {
            new List<string>(){"X"," "," "},
            new List<string>(){"X"," "," "},
            new List<string>(){"X"," "," "}
        },
        new List<List<string>>()
        {
            new List<string>(){" ","X"," "},
            new List<string>(){" ","X"," "},
            new List<string>(){" ","X"," "}
        },
        new List<List<string>>()
        {
            new List<string>(){" "," ","X"},
            new List<string>(){" "," ","X"},
            new List<string>(){" "," ","X"}
        },
        new List<List<string>>()
        {
            new List<string>(){"X"," "," "},
            new List<string>(){" ","X"," "},
            new List<string>(){" "," ","X"}
        },
        new List<List<string>>()
        {
            new List<string>(){" "," ","X"},
            new List<string>(){" ","X"," "},
            new List<string>(){"X"," "," "}
        }
    };

                List<List<List<string>>> winBoardsO = new List<List<List<string>>>()
    {
        new List<List<string>>()
        {
            new List<string>(){"O","O","O"},
            new List<string>(){" "," "," "},
            new List<string>(){" "," "," "}
        },
        new List<List<string>>()
        {
            new List<string>(){" "," "," "},
            new List<string>(){"O","O","O"},
            new List<string>(){" "," "," "}
        },
        new List<List<string>>()
        {
            new List<string>(){" "," "," "},
            new List<string>(){" "," "," "},
            new List<string>(){"O","O","O"}
        },
        new List<List<string>>()
        {
            new List<string>(){"O"," "," "},
            new List<string>(){"O"," "," "},
            new List<string>(){"O"," "," "}
        },
        new List<List<string>>()
        {
            new List<string>(){" ","O"," "},
            new List<string>(){" ","O"," "},
            new List<string>(){" ","O"," "}
        },
        new List<List<string>>()
        {
            new List<string>(){" "," ","O"},
            new List<string>(){" "," ","O"},
            new List<string>(){" "," ","O"}
        },
        new List<List<string>>()
        {
            new List<string>(){"O"," "," "},
            new List<string>(){" ","O"," "},
            new List<string>(){" "," ","O"}
        },
        new List<List<string>>()
        {
            new List<string>(){" "," ","O"},
            new List<string>(){" ","O"," "},
            new List<string>(){"O"," "," "}
        }
    };

                //create board with O's removed

                //Create board with X's removed

                //Check if X won
                foreach (List<List<String>> winboard in winBoardsO)
                {

                }

                //check if O won

                //End the game if there is a winner

                return false;
            }
        }
    }
}