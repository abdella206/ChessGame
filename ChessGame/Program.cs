using ChessBoard;
using System;

namespace ChessGame
{
    class Program
    {
        static Board myBoard = new Board(8);
        static void Main(string[] args)
        {

            while (true)
            {

                // Show empty chess board
                printBoard(myBoard);

                // ask the user for an x and y coordinate where we will place a piece

                Cell currentCell = setCurrentCell();
                currentCell.CurrentlyOccupied = true;



                // calculate all legal moves for that piece
                Console.WriteLine("What kind of chess piece would you like to place? Knight, King, Queen, Rook, Bishop?");
                string inputPiece = Console.ReadLine();
                myBoard.MarkNextLegalMoves(currentCell, inputPiece.ToLower());

                // print the chess board Use an x for occupied square + for a legal move and use a . for an empty cell
                printBoard(myBoard);

                // wait for another enter key press before ending program

                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            
        }
        }

        private static Cell setCurrentCell()
        {
            try
           {
            // get x and y coordinate from user and return cell location
            Console.WriteLine("Enter the current row number");
            int currentRow = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the current colum number");
            int currentColum = int.Parse(Console.ReadLine());

            

            return myBoard.theGrid[currentRow, currentColum];

            }
            catch (Exception)
            {
                Console.WriteLine("You enter a number out of range plaese enter again");
                int currentRow = int.Parse(Console.ReadLine());
                int currentColum = int.Parse(Console.ReadLine());
                return myBoard.theGrid[currentRow, currentColum];
            }



        }

        public static void printBoard(Board myBoard) {
            // print the chess board Use an x for occupied square + for a legal move and use a . for an empty cell
            for (int i = 0; i < myBoard.Size; i++) {

                for (int j = 0; j < myBoard.Size; j++) {

                    Cell c = myBoard.theGrid[i, j];

                    if (c.CurrentlyOccupied == true) {

                        Console.Write("  X  ");

                    } else if (c.LegalNextMove == true) {

                        Console.Write("  +  ");

                    } else {
                        Console.Write("  .  ");
                        


                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("======================================");


        }















    }
}
