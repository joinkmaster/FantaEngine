using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot
{
    internal class Queen : Piece
    {
        public override int Value => 9;
        public override PieceType Type => PieceType.Queen;
        public Queen(Color color, Position position) : base(position, color)
        {

        }

        public override string ToString()
        {
            return "♛";
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
