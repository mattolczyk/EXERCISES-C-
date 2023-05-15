using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using ex6hangmanGame;
using static System.Net.Mime.MediaTypeNames;

Random random = new Random((int)DateTime.Now.Ticks);

string[] wordBank = { "Blue", "Black", "Yellow", "Orange", "Green", "Purple", "Grey", "White" };
string wordToGuessLowercase = wordBank[random.Next(0, wordBank.Length)];
string wordToGuess = wordToGuessLowercase.ToUpper();

//Hide all characters 
StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length);
for (int i = 0; i < wordToGuess.Length; i++)
    displayToPlayer.Append('_');


List<char> correctGuesses = new List<char>();
List<char> incorrectGuesses = new List<char>();
int lives = 5;
bool won = false;
int lettersGuesed = 0;

Console.WriteLine("WELCOME TO HANGMAN GAME !!! TRY TO GUESS A WORD");
var Graphics = new Graphics();
int firstMessage = 1;

while (!won && lives > 0)
{
    Console.WriteLine(displayToPlayer.ToString());
    Console.WriteLine("Guess a letter: ");
    Graphics.DrawHangman(lives);
    string input = Console.ReadLine().ToUpper();
    char letter = input[0];  // takes only first leter 
    Console.Clear();

    if (correctGuesses.Contains(letter))
    {
        Console.WriteLine("You've already tried '{0}', and it was correct!", letter);
        continue;
    }
    else if (incorrectGuesses.Contains(letter))
    {
        Console.WriteLine("You've already tried '{0}', and it was wrong!", letter);
        continue;
    }
    else
    {
        if (wordToGuess.Contains(letter))
        {
            correctGuesses.Add(letter);
            Console.WriteLine("Correct letter '{0}' - keep quesing!", letter);
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == letter)
                {
                    displayToPlayer[i] = wordToGuess[i];
                    lettersGuesed++;
                }
            }
        }
        else
        {
            incorrectGuesses.Add(letter);
            Console.WriteLine("Nope, there's no '{0}' in it!", letter);
            lives--;
        }
    }

    if (lettersGuesed == wordToGuess.Length)
        won = true;

}


if (won = true)
{ 
    Console.Clear();
    Console.WriteLine("You won!");
    Console.WriteLine("It was '{0}'", wordToGuess);
}
else
{
    Console.Clear();
    Console.WriteLine("You lost!");
    Console.WriteLine("It was '{0}'", wordToGuess);
    Graphics.DrawHangman(lives);
}


Console.Write("Press ENTER to exit...");
Console.ReadLine();
