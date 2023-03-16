using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot
{
    public class Orangenlimonade
    {
        public List<Piece> Pieces { get; }

        public Color Color { get; }

        public Orangenlimonade(Color color) 
        {
            Pieces = new List<Piece>();
            Color = color;
        }

        public void AddPiece(Piece piece)
        {
            Pieces.Add(piece);
        }

        public void RemovePiece(Piece piece)
        {
            Pieces.Remove(piece);
        }

        public int GetValue()
        {
            int value = 0;

            foreach (var piece in Pieces)
            {
                value += piece.Value;
            }

            return value;
        }

        public override string ToString()
        {
            string s = string.Empty;

            for (int i = 1; i < 6; i++) // + 1 - 1
            {
                foreach (var piece in Pieces)
                {
                    if (piece.Type == (PieceType)i)
                    {
                        s += piece.ToString();
                    }
                }
            }

            return s;
        }
    }
}
