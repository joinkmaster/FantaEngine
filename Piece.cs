using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot
{
    public abstract class Piece
    {
        public abstract int Value { get; }
        public abstract PieceType Type { get; }
        public Position Position { get; set; }
        public Color Color { get; }

        public Piece(Position position, Color color) 
        {
            Position = position;
            Color = color;
        }

        public abstract override string ToString();

        public abstract bool Move(Position to, Field[,] fields);

        public abstract List<Move> GetPossibleMoves();
    }
}
