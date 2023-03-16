
namespace ChessBot
{
    public class Field
    {
        public Owner Owner { get; set; }
        public Piece? Piece { get; set; }

        public Field()
        {
            Owner = Owner.None;
        }
        public override string ToString()
        {
            if (Piece == null)
            {
                return " ";
            }

            else
            {
                return Piece.ToString();
            }
        }
    }
}
