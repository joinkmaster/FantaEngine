using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot
{
    public sealed class Util
    {
        public static Position ConvertToPosition(int row, int col)
        {
            return (Position)(row * 8 + col);
        }
        public static Position ConvertToPosition(Int2 position)
        {
            return (Position)(position.Row * 8 + position.Col);
        }

        public static Int2 ConvertToInt2(Position position)
        {
            int row = (int)position % 8;
            int col = (int)position / 8;

            return new Int2(row, col);
        }
    }
}
