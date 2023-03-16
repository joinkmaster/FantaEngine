using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot
{
    internal class Rook : Piece
    {
        public override int Value => 5;
        public override PieceType Type => PieceType.Rook;
        public Rook(Color color, Position position) : base(position, color)
        {

        }

        public override string ToString()
        {
            return "♜";
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
