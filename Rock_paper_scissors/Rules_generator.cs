using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Rock_Paper_Scissors
{
    public class Rules_generator
    {
        public static int WinnerRules(string[] moves, int computerChoice, int userChoice)
        {

            int half = moves.Length / 2;
            int result = Math.Sign(((computerChoice - userChoice + half + moves.Length) % moves.Length - half));
            if (userChoice == computerChoice)
            {

                return 0;
            }
            else if (result == 1)
            {

                return 1;
            }
            else
            {

                return -1;
            }

        }

    }
}
