using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot
{
    public class FantaEngine
    {

        private readonly Random r = new Random();

        private Board _board;

        private bool _isRunning;

        private bool _playersTurn;

        public Orangenlimonade Bot { get; }

        public Color BotColor { get; }
        public FantaEngine()
        {
            _board = new Board();
            
            _isRunning = true;

            BotColor = (Color)r.Next(0, 2);

            _board.Init(BotColor);

            Bot = new Orangenlimonade(BotColor);

            SetPieces(BotColor);

            _playersTurn = BotColor == Color.Black;
        }

        public void Run()
        {
            while (_isRunning)
            {
                Print();
                Move();
                Console.Clear();
            }
        }

        private bool SetPieces(Color color)
        {
            if (color == Color.White)
            {
                Bot.AddPiece(_board.Fields[0, 0].Piece);
                Bot.AddPiece(_board.Fields[0, 1].Piece);
                Bot.AddPiece(_board.Fields[0, 2].Piece);
                Bot.AddPiece(_board.Fields[0, 3].Piece);
                Bot.AddPiece(_board.Fields[0, 4].Piece);
                Bot.AddPiece(_board.Fields[0, 5].Piece);
                Bot.AddPiece(_board.Fields[0, 6].Piece);
                Bot.AddPiece(_board.Fields[0, 7].Piece);
                Bot.AddPiece(_board.Fields[1, 0].Piece);
                Bot.AddPiece(_board.Fields[1, 1].Piece);
                Bot.AddPiece(_board.Fields[1, 2].Piece);
                Bot.AddPiece(_board.Fields[1, 3].Piece);
                Bot.AddPiece(_board.Fields[1, 4].Piece);
                Bot.AddPiece(_board.Fields[1, 5].Piece);
                Bot.AddPiece(_board.Fields[1, 6].Piece);
                Bot.AddPiece(_board.Fields[1, 7].Piece);
            }
            else
            {
                Bot.AddPiece(_board.Fields[6, 0].Piece);
                Bot.AddPiece(_board.Fields[6, 1].Piece);
                Bot.AddPiece(_board.Fields[6, 2].Piece);
                Bot.AddPiece(_board.Fields[6, 3].Piece);
                Bot.AddPiece(_board.Fields[6, 4].Piece);
                Bot.AddPiece(_board.Fields[6, 5].Piece);
                Bot.AddPiece(_board.Fields[6, 6].Piece);
                Bot.AddPiece(_board.Fields[6, 7].Piece);
                Bot.AddPiece(_board.Fields[7, 0].Piece);
                Bot.AddPiece(_board.Fields[7, 1].Piece);
                Bot.AddPiece(_board.Fields[7, 2].Piece);
                Bot.AddPiece(_board.Fields[7, 3].Piece);
                Bot.AddPiece(_board.Fields[7, 4].Piece);
                Bot.AddPiece(_board.Fields[7, 5].Piece);
                Bot.AddPiece(_board.Fields[7, 6].Piece);
                Bot.AddPiece(_board.Fields[7, 7].Piece);
            }

            return Bot.Pieces.Count == 16;
        }

        private void Print()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;

            if (BotColor == Color.White)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }

            Console.WriteLine(Bot.ToString());
            Console.WriteLine();
            _board.PrintBoard(BotColor);
            Console.WriteLine();

            Console.WriteLine(BotColor);
        }

        private void Move()
        {
            Piece? pawn = null;
            bool moveValid;
            bool moveDone = false;
            Move? move = null;
            while (!moveDone)
            {
                moveValid = false;
                while (!moveValid)
                {
                    Console.Write("Enter your move here: ");
                    move = InputManager.ValidateInput(Console.ReadLine(), out moveValid);
                    Console.WriteLine(move);
                }
                if (move != null && move.From != null && move.To != null)
                {
                    pawn = _board.Fields[1, 6].Piece;
                    pawn.Move(Position.g3, _board.Fields);
                    Console.WriteLine(pawn);
                    moveDone = true;
                    Piece? p = _board.Fields[move.From.Row, move.From.Col].Piece;
                    
                    //if (p != null)
                    //{
                    //    moveDone = p.Move(Util.ConvertToPosition(move.To), _board.Fields);
                    //}
                }
            }
            _board.Fields[move.To.Row, move.To.Col].Owner = _board.Fields[move.From.Row, move.From.Col].Owner;
            _board.Fields[move.From.Row, move.From.Col].Owner = Owner.None;
            _board.Fields[move.To.Row, move.To.Col].Piece = _board.Fields[move.From.Row, move.From.Col].Piece;
            _board.Fields[move.From.Row, move.From.Col].Piece = null;

            Console.WriteLine(pawn);
        }
    }
}
