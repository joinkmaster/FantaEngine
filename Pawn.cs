using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot
{
    sealed class Pawn : Piece
    {
        public override int Value => 1;
        public override PieceType Type => PieceType.Pawn;

        public int Row;
        public Pawn(Color color, Position position) : base(position, color)
        {
            Row = 1;
        }

        public override string ToString()
        {
            return "♙";
        }

        public override bool Move(Position to, Field[,] fields)
        {
            Int2 moveTo = Util.ConvertToInt2(to);
            Int2 moveFrom = Util.ConvertToInt2(Position);

            if (moveTo.Col == moveFrom.Col && //the field is in the same col above the current field
                fields[Util.ConvertToInt2(to).Row, Util.ConvertToInt2(to).Col].Owner == Owner.None) //the field the pawn wants to move to is empty
            {
                if ((this.Color == Color.White && moveTo.Row == moveFrom.Row + 1) ||
                    (this.Color == Color.Black && moveTo.Row == moveFrom.Row - 1))
                {
                    this.Position = Util.ConvertToPosition(moveTo);
                    return true;
                }
            }
            else
            {
                return false;
            }


            return false;
        }
        public override List<Move> GetPossibleMoves()
        {
            return new List<Move>();
        }
    }
}
