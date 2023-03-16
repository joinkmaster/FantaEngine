using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot
{
    static class InputManager
    {
        static InputManager() 
        {
            
        }

        public static Move? ValidateInput(string? input, out bool valid) //has to be like "a1 a1"
        {
            if (input == null || input.Length < 2)
            {
                valid = false;
                return null;
            }

            if (input.Length == 5 &&
                (int)input[0] is > 96 and < 105 &&
                (int)input[1] is > 48 and < 57 &&
                input[2] == ' ' &&
                (int)input[3] is > 96 and < 105 &&
                (int)input[4] is > 48 and < 57)
            {
                valid = true;
                return new Move(new Int2(input[0] - 97, input[1] - 49), new Int2(input[3] - 97, input[4] - 49));
            }
            else
            {
                valid = false;
                return null;
            }

        }
    }
}
