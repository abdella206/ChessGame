﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{
    public class ChessPieces
    {

        public  ChessPieces()
        {
           

            
        }


        public  int[,] Bishop = {
                                 {-1, 1 }, {-2, 2 }, {-3, 3 }, {-4, 4 }, {-5, 5 }, {-6, 6 }, {-7, 7 }, {-8, 8 },
                                 { 1,-1 }, {2, -2 }, {3, -3 }, {4, -4 }, {5, -5 }, {6, -6 }, {7, -7 }, {8, -8 },
                                 { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 }, { 5, 5 }, { 6, 6 }, { 7, 7 }, { 8, 8 },
                                 { -1, -1 }, { -2, -2 }, { -3, -3 }, { -4, -4 }, { -5, -5 }, { -6, -6 }, { -7, -7 }, {-8, -8}
                               };

        public  int[,] Knight = { { -2, -1 }, { -2, 1 }, { 2, -1 }, { 2, 1 }, { 1, 2 }, { 1, -2 }, { -1, -2 }, { -1, 2 } };

        public  int[,] King = { { -1, -1 }, { -1, 0 }, { -1, 1 }, { 0, -1 }, { 0, 1 }, { 1, 1 }, { 1, 0 }, { 1, -1 }, { 1, 1 }, { 1, -1 } };

        public  int[,] Rook = {
                                { -7, 0 }, { -6, 0 }, { -5, 0 }, { -4, 0 }, { -3, 0 }, { -2, 0 }, { -1, 0 }, { 0, -1 }, { 0, -2 }, { 0, -3 },
                                { 0, -4 }, { 0, -5 }, { 0, -6 }, {0, -7 }, { 0, 1 }, { 0, 2 }, { 0, 3 }, { 0, 4 }, { 0, 5 }, { 0, 6 }, { 0, 7 },
                                { 1, 0}, {2, 0}, {3, 0}, {4, 0}, { 5, 0 }, { 6, 0 }, { 7, 0 }, { 8, 0 }
                             };

        public  int[,] Queen = {
                                 {-1, 1 }, {-2, 2 }, {-3, 3 }, {-4, 4 }, {-5, 5 }, {-6, 6 }, {-7, 7 }, {-8, 8 },
                                 { 1,-1 }, {2, -2 }, {3, -3 }, {4, -4 }, {5, -5 }, {6, -6 }, {7, -7 }, {8, -8 },
                                 { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 }, { 5, 5 }, { 6, 6 }, { 7, 7 }, { 8, 8 },
                                 { -1, -1 }, { -2, -2 }, { -3, -3 }, { -4, -4 }, { -5, -5 }, { -6, -6 }, { -7, -7 }, {-8, -8},

                                 { -7, 0 }, { -6, 0 }, { -5, 0 }, { -4, 0 }, { -3, 0 }, { -2, 0 }, { -1, 0 }, { 0, -1 }, { 0, -2 }, { 0, -3 },
                                 { 0, -4 }, { 0, -5 }, { 0, -6 }, {0, -7 }, { 0, 1 }, { 0, 2 }, { 0, 3 }, { 0, 4 }, { 0, 5 }, { 0, 6 }, { 0, 7 },
                                 { 1, 0}, {2, 0}, {3, 0}, {4, 0}, { 5, 0 }, { 6, 0 }, { 7, 0 }, { 8, 0 }

                              };


    }
}
