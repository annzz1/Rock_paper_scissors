using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Rock_Paper_Scissors
{
    public class HelperFuntions
    {
        public static bool isUnique(string[] Moves)
        {
            if (Moves.Length == 0) return false;
            HashSet<string> visitedMoves = new HashSet<string>();
            foreach (string move in Moves)
            {
                if (visitedMoves.Contains(move))
                {
                   
                    return false;
                }
                visitedMoves.Add(move);

            }
            return true;
        }
        public static void ShowMenu(string[] moves)
        {
            Console.WriteLine("Available moves:");
            for (int i = 0; i < moves.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {moves[i]}");
            }
            Console.WriteLine("0 - Exit");
            Console.WriteLine("? - Help");
        }
        public static int CalculateComputerMove(string[] moves)
        {
            Random random = new Random();
            int ComputerMove = random.Next(0, moves.Length);
            return ComputerMove;
        }
        public static int CalculateUserMove(string[] moves)
        {
            while (true)
            {
                ShowMenu(moves);

                Console.Write("Choose your move: ");
                string? choice = Console.ReadLine();
                if (choice == "0")
                {
                    Console.WriteLine("Exiting the program!");
                    Environment.Exit(0);
                }
                else if (choice == "?")
                {
                    Help_Table_generator.HelpTable(moves);

                }
                else
                {
                    int.TryParse(choice, out int move);
                    if (move > 0 && move <= moves.Length)
                    {
                        return move - 1;

                    }

                    Console.WriteLine("Invalid input. Please enter a number corresponding to the move.");
                }
            }


        }
    }
}
