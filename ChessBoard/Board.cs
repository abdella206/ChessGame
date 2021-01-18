using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{

   public class Board
    {
        
        // Constructor 
        public Board(int s)
        {
            // Initial size of the board is defined by s.
            Size = s;

            // Create a new 2D array of type cell
            theGrid = new Cell[Size, Size];

            // Filling the 2D array with new Cells, each unique x and y coordinates.
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);

                }

            }
        }


        ChessPieces myPiece = new ChessPieces();


        //size of board is usally 8x8
        public int Size { get; set; }

        public Cell[,] theGrid { get; set; }

        public bool isSafe(int x, int y) {
            if(x < 0 || x >= Size || y < 0 || y >= Size) {

                Console.WriteLine($"this move {x}, {y} is not legal");
            return false;
            }
            else
            {
                Console.WriteLine($"this move {x}, {y} is legal");
                return true;
            }

        }
        public void MarkNextLegalMoves(Cell currentCell, string chessPiece)
        {
           
            
            // step 1 - clear all previous legal moves
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j].LegalNextMove = false;
                    theGrid[i, j].CurrentlyOccupied = false;

                }

            }

            // step 2 - find all legal moves and mark the cells as legal
           
                switch (chessPiece)
                {
                    case "knight":

                    for (int i = 0; i < myPiece.Knight.GetLength(0) - 1; i++)
                    {

                        if (isSafe(currentCell.RowNumber + myPiece.Knight[i, 0], currentCell.ColumnNumber + myPiece.Knight[i, 1]))
                            theGrid[currentCell.RowNumber + myPiece.Knight[i, 0], currentCell.ColumnNumber + myPiece.Knight[i, 1]].LegalNextMove = true;
                    }

                    break;

                    case "king":


                    for (int i = 0; i < myPiece.King.GetLength(0) - 1; i++)
                    {

                        if (isSafe(currentCell.RowNumber + myPiece.King[i, 0], currentCell.ColumnNumber + myPiece.King[i, 1]))
                            theGrid[currentCell.RowNumber + myPiece.King[i, 0], currentCell.ColumnNumber + myPiece.King[i, 1]].LegalNextMove = true;
                    }
                  

                    break;

                    case "rook":

                    for (int i = 0; i < myPiece.Rook.GetLength(0) - 1; i++)
                    {

                        if (isSafe(currentCell.RowNumber + myPiece.Rook[i, 0], currentCell.ColumnNumber + myPiece.Rook[i, 1]))
                            theGrid[currentCell.RowNumber + myPiece.Rook[i, 0], currentCell.ColumnNumber + myPiece.Rook[i, 1]].LegalNextMove = true;
                    }

                        break;

                    case "bishop":

                    for (int i = 0; i < myPiece.Bishop.GetLength(0) - 1; i++)
                    {

                        if (isSafe(currentCell.RowNumber + myPiece.Bishop[i, 0], currentCell.ColumnNumber + myPiece.Bishop[i, 1]))
                            theGrid[currentCell.RowNumber + myPiece.Bishop[i, 0], currentCell.ColumnNumber + myPiece.Bishop[i, 1]].LegalNextMove = true;
                    }


                    break;

                    case "queen":

                    for (int i = 0; i < myPiece.Queen.GetLength(0) - 1; i++)
                    {

                        if (isSafe(currentCell.RowNumber + myPiece.Queen[i, 0], currentCell.ColumnNumber + myPiece.Queen[i, 1]))
                            theGrid[currentCell.RowNumber + myPiece.Queen[i, 0], currentCell.ColumnNumber + myPiece.Queen[i, 1]].LegalNextMove = true;
                    }
                    break;

                    default:

                        break;
                }


                theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
      

        }







    }
}








//if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber + 1))
//    theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;

//if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber + 1))
//    theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;

//if (isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber - 1))
//    theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;

//if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber + 2))
//    theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;

//if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber - 2))
//    theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;

//if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber + 2))
//    theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;

//if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber - 2))
//    theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;





//theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
//theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
//theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;

//theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
//theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
//theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;

//theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
//theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 1].LegalNextMove = true;
//theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;


//theGrid[currentCell.RowNumber - 0, currentCell.ColumnNumber - 1].LegalNextMove = true;





//theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
//theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 0].LegalNextMove = true;
//theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 0].LegalNextMove = true;
//theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber + 0].LegalNextMove = true;
//theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber + 0].LegalNextMove = true;


//theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
//theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 0].LegalNextMove = true;
//theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber + 0].LegalNextMove = true;





//theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 1].LegalNextMove = true;
//theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 2].LegalNextMove = true;
//theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 3].LegalNextMove = true;
//theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 4].LegalNextMove = true;



//theGrid[currentCell.RowNumber - 0, currentCell.ColumnNumber - 1].LegalNextMove = true;
//theGrid[currentCell.RowNumber - 0, currentCell.ColumnNumber - 2].LegalNextMove = true;
//theGrid[currentCell.RowNumber - 0, currentCell.ColumnNumber - 3].LegalNextMove = true;
