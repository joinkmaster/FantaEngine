using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot
{
    internal class Bishop : Piece
    {
        public override int Value => 3;
        public override PieceType Type => PieceType.Bishop;
        public Bishop(Color color, Position position) : base(position, color)
        {

        }

        public override string ToString()
        {
            return "♝";
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
