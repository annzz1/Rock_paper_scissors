using ConsoleTable;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Rock_Paper_Scissors
{
    public class Help_Table_generator
    {
        public static void HelpTable(string[] moves)
        {
            var table = new Table();
            table.AddColumn("PC/USER >");
            table.AddColumn(moves);

            Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();
            for (int i = 0; i < moves.Length; i++)
            {
                var resultList = new List<string>();
                resultList.Add(moves[i]);
                for (int j = 0; j < moves.Length; j++)
                {
                    int result = Rules_generator.WinnerRules(moves, i + 1, j + 1);
                    string resultString = "";
                    if (result == 0)
                    {
                        resultString = "draw";
                    }
                    else if (result == 1)
                    {
                        resultString = "Win";
                    }
                    else if (result == -1)
                    {
                        resultString = "Lose";
                    }
                    resultList.Add(resultString);
                }
                table.AddRow(resultList.ToArray());
            }
            Console.WriteLine(table.AddSeparatorForEachRow());

        }
    }
}
