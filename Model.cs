﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot
{
    /// <summary>
    /// Holds position information like in a chess game, from a1 to h8.
    /// </summary>
    public enum Position
    {
        a1, a2, a3, a4, a5, a6, a7, a8,
        b1, b2, b3, b4, b5, b6, b7, b8,
        c1, c2, c3, c4, c5, c6, c7, c8,
        d1, d2, d3, d4, d5, d6, d7, d8,
        e1, e2, e3, e4, e5, e6, e7, e8,
        f1, f2, f3, f4, f5, f6, f7, f8,
        g1, g2, g3, g4, g5, g6, g7, g8,
        h1, h2, h3, h4, h5, h6, h7, h8,
    }

    public enum Color
    {
        Black,
        White
    }

    public enum Owner
    {
        Black,
        White,
        None
    }

    public enum PieceType
    {
        King,
        Queen,
        Rook,
        Bishop,
        Knight,
        Pawn
    }

    /// <summary>
    /// Holds 2 int values
    /// </summary>
    /// <param name="Row"></param>
    /// <param name="Col"></param>
    public record Int2(int Row, int Col);

    public record Move(Int2 From, Int2 To);

}