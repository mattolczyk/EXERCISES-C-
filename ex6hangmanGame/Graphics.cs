using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6hangmanGame
{
    internal class Graphics
    {
        public void DrawHangman(int lives) 
        {

            if (lives == 0)
            {
                Console.WriteLine("\n" + @",------," + "\n" + @"|      |" + "\n" + @"|      O" + "\n" + @"|     /|\" + "\n" + @"|     / \" + "\n" + @"|_______");
            }
            if (lives == 1)
            {
                Console.WriteLine("\n" + @",------," + "\n" + @"|      |" + "\n" + @"|      O" + "\n" + @"|     /|\" + "\n" + @"|" + "\n" + @"|________");
            }
            if (lives == 2)
            {
                Console.WriteLine("\n" + @",------," + "\n" + @"|      |" + "\n" + @"|      O" + "\n" + @"|      |" + "\n" + @"|" + "\n" + @"|________");
            }
            if (lives == 3)
            {
                Console.WriteLine("\n" + @",------," + "\n" + @"|      |" + "\n" + @"|      O" + "\n" + @"|" + "\n" + @"|" + "\n" + @"|________");
            }
            if (lives == 4)
            {
                Console.WriteLine("\n" + @",------," + "\n" + @"|      |" + "\n" + @"|" + "\n" + @"|" + "\n" + @"|" + "\n" + @"|________");
            }

        }
    }
}
