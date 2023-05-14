// See https://aka.ms/new-console-template for more information
using ex5pswerdchecker;




var calculate = new ScoreCalculator();


while (true)
{
    Console.WriteLine("###########################################################################");
    Console.WriteLine("Provide your password and hit enter for strength check:");
    string password = Console.ReadLine();
    var score = calculate.CheckStrength(password);
    Console.WriteLine("Your password strength  (0 - very weak, 5 - very strong): " + score);
}
