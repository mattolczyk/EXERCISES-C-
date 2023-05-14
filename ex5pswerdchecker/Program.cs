// See https://aka.ms/new-console-template for more information
using ex5pswerdchecker;



var calculate = new ScoreCalculator();


while (true)
{
    string password = Console.ReadLine();
    var score = calculate.CheckStrength(password);
    Console.WriteLine(score);
}
