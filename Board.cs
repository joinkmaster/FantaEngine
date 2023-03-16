using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot
{
    public class Board
    {
        public Field[,] Fields = new Field[8, 8]; //rows, columns
        public Board()
        {
            Console.OutputEncoding = Encoding.Unicode;
        }

        public void Init(Color botColor)
        {

            for (int i = 0; i < 8; i++) 
            { 
                for (int j = 0; j < 8; j++)
                {
                    Fields[i, j] = new Field();
                }
            }

            //set white pieces
            Fields[0, 0].Owner = Owner.White;
            Fields[0, 0].Piece = new Rook(Color.White, Util.ConvertToPosition(1, 1));

            Fields[0, 1].Owner = Owner.White;
            Fields[0, 1].Piece = new Knight(Color.White, Util.ConvertToPosition(1, 2));

            Fields[0, 2].Owner = Owner.White;
            Fields[0, 2].Piece = new Bishop(Color.White, Util.ConvertToPosition(1, 3));

            Fields[0, 3].Owner = Owner.White;
            Fields[0, 3].Piece = new Queen(Color.White, Util.ConvertToPosition(1, 4));

            Fields[0, 4].Owner = Owner.White;
            Fields[0, 4].Piece = new King(Color.White, Util.ConvertToPosition(1, 5));

            Fields[0, 5].Owner = Owner.White;
            Fields[0, 5].Piece = new Bishop(Color.White, Util.ConvertToPosition(1, 6));

            Fields[0, 6].Owner = Owner.White;
            Fields[0, 6].Piece = new Knight(Color.White, Util.ConvertToPosition(1, 7));

            Fields[0, 7].Owner = Owner.White;
            Fields[0, 7].Piece = new Rook(Color.White, Util.ConvertToPosition(1, 8));

            Fields[1, 0].Owner = Owner.White;
            Fields[1, 0].Piece = new Pawn(Color.White, Util.ConvertToPosition(2, 1));

            Fields[1, 1].Owner = Owner.White;
            Fields[1, 1].Piece = new Pawn(Color.White, Util.ConvertToPosition(2, 2));

            Fields[1, 2].Owner = Owner.White;
            Fields[1, 2].Piece = new Pawn(Color.White, Util.ConvertToPosition(2, 3));

            Fields[1, 3].Owner = Owner.White;
            Fields[1, 3].Piece = new Pawn(Color.White, Util.ConvertToPosition(2, 4));

            Fields[1, 4].Owner = Owner.White;
            Fields[1, 4].Piece = new Pawn(Color.White, Util.ConvertToPosition(2, 5));

            Fields[1, 5].Owner = Owner.White;
            Fields[1, 5].Piece = new Pawn(Color.White, Util.ConvertToPosition(2, 6));

            Fields[1, 6].Owner = Owner.White;
            Fields[1, 6].Piece = new Pawn(Color.White, Util.ConvertToPosition(2, 7));

            Fields[1, 7].Owner = Owner.White;
            Fields[1, 7].Piece = new Pawn(Color.White, Util.ConvertToPosition(2, 8));

            //set black pieces
            Fields[7, 0].Owner = Owner.Black;
            Fields[7, 0].Piece = new Rook(Color.Black, Util.ConvertToPosition(8, 1));

            Fields[7, 1].Owner = Owner.Black;
            Fields[7, 1].Piece = new Knight(Color.Black, Util.ConvertToPosition(8, 2));

            Fields[7, 2].Owner = Owner.Black;
            Fields[7, 2].Piece = new Bishop(Color.Black, Util.ConvertToPosition(8, 3));

            Fields[7, 3].Owner = Owner.Black;
            Fields[7, 3].Piece = new Queen(Color.Black, Util.ConvertToPosition(8, 4));

            Fields[7, 4].Owner = Owner.Black;
            Fields[7, 4].Piece = new King(Color.Black, Util.ConvertToPosition(8, 5));

            Fields[7, 5].Owner = Owner.Black;
            Fields[7, 5].Piece = new Bishop(Color.Black, Util.ConvertToPosition(8, 6));

            Fields[7, 6].Owner = Owner.Black;
            Fields[7, 6].Piece = new Knight(Color.Black, Util.ConvertToPosition(8, 7));

            Fields[7, 7].Owner = Owner.Black;
            Fields[7, 7].Piece = new Rook(Color.Black, Util.ConvertToPosition(8, 8));

            Fields[6, 0].Owner = Owner.Black;
            Fields[6, 0].Piece = new Pawn(Color.Black, Util.ConvertToPosition(7, 1));

            Fields[6, 1].Owner = Owner.Black;
            Fields[6, 1].Piece = new Pawn(Color.Black, Util.ConvertToPosition(7, 2));

            Fields[6, 2].Owner = Owner.Black;
            Fields[6, 2].Piece = new Pawn(Color.Black, Util.ConvertToPosition(7, 3));

            Fields[6, 3].Owner = Owner.Black;
            Fields[6, 3].Piece = new Pawn(Color.Black, Util.ConvertToPosition(7, 4));

            Fields[6, 4].Owner = Owner.Black;
            Fields[6, 4].Piece = new Pawn(Color.Black, Util.ConvertToPosition(7, 5));

            Fields[6, 5].Owner = Owner.Black;
            Fields[6, 5].Piece = new Pawn(Color.Black, Util.ConvertToPosition(7, 6));

            Fields[6, 6].Owner = Owner.Black;
            Fields[6, 6].Piece = new Pawn(Color.Black, Util.ConvertToPosition(7, 7));

            Fields[6, 7].Owner = Owner.Black;
            Fields[6, 7].Piece = new Pawn(Color.Black, Util.ConvertToPosition(7, 8));
        }

        public void PrintBoard(Color botColor)
        {
            void SetColors(int field)
            {
                Owner owner = Fields[field / 8, field % 8].Owner;

                if ((field % 2 == 0 && field % 16 < 8 || field % 2 == 1 && field % 16 >= 8) && botColor == Color.Black ||
                    !((field % 2 == 0 && field % 16 < 8 || field % 2 == 1 && field % 16 >= 8)) && botColor == Color.White)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                }

                if (owner == Owner.White)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (owner == Owner.Black)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }

            void ResetColors()
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }

            int x = 1;
            int field;
            if (botColor == Color.White)
            {
                field = 0;
            }
            else
            {
                field = 63;
            }

            for (int row = 0; row < 8;  row++) 
            {
                for(int col = 0; col < 8; col++)
                {
                    SetColors(field);
                    if (Fields[row, col] != null &&
                        Fields[row, col].Piece != null)
                    {
                        if (botColor == Color.White)
                        {
                            Console.Write($"{Fields[row, col].Piece.ToString()} ");
                        }
                        else
                        {
                            Console.Write($"{Fields[7 - row, col].Piece} ");
                        }
                    }
                    else
                    {
                        Console.Write($"  ");
                    }
                    ResetColors();
                    if (botColor == Color.White)
                    {
                        field++;
                    }
                    else
                    {
                        field--;
                    }
                }
                if (botColor == Color.White) 
                { 
                    Console.Write(x++);
                } 
                else
                {
                    Console.Write(9 - x++);
                }
                Console.WriteLine();
            }
            if (botColor == Color.Black)
            {
                Console.WriteLine("a b c d e f g h");
            }
            else
            {
                Console.WriteLine("h g f e d c b a");
            }

        }
    }
}