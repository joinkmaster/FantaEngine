using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot
{
    internal class Knight : Piece
    {
        public override int Value => 3;
        public override PieceType Type => PieceType.Knight;
        public Knight(Color color, Position position) : base(position, color)
        {

        }

        public override string ToString()
        {
            return "♞";
        }

        public override bool Move(Position to, Field[,] fields)
        {
            return false;
        }

        public override List<Move> GetPossibleMoves()
        {
            return new List<Move>();
        }
    }
}
