using Microsoft.VisualBasic;
using Org.BouncyCastle.Security;
using Task3_Rock_Paper_Scissors;

//Main Function
var UniqueMoves = HelperFuntions.isUnique(args);

while ( args.Length >= 3 && args.Length % 2 == 1 && UniqueMoves==true)
{
    var HMAC_key = HMAC_Key_generator.KeyGenerator();
    var computerMove = HelperFuntions.CalculateComputerMove(args);
    var hmac = HMAC_generator.GetHMAC(args[computerMove], HMAC_key);
    Console.WriteLine($"HMAC: {hmac}");
    var userMove = HelperFuntions.CalculateUserMove(args);
    Console.WriteLine($"Your move: {args[userMove]}");
    Console.WriteLine($"Computer move: {args[computerMove]}");
    int result = Rules_generator.WinnerRules(args, userMove, computerMove);
    if (result == 0) { Console.WriteLine("It's a tie!"); }
    if (result == 1) { Console.WriteLine("User wins!"); }
    if (result == -1) { Console.WriteLine("Computer wins!"); }
    Console.WriteLine($"HMAC key: {HMAC_key}");
    Console.WriteLine();
}
if (args.Length < 3)
{
    Console.WriteLine("-Invalid input- Please enter More than 3 Moves!");
}
if (args.Length % 2 == 0)
{
    Console.WriteLine("-Invalid input - Please enter an odd number of Moves!");
}
if (!UniqueMoves)
{
    Console.WriteLine("-Invalid input- Either empty or Duplicates found! Please enter correct input!");
}
