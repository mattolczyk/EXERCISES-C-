using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2birthdays
{
    public class Menu 
    {
        public List<Friend> myList { get; set; } = new List<Friend>();
        public void ShowMenu()
        {
            Console.WriteLine("############################### WHAT TO DO  ###############################");
            Console.WriteLine("TYPE: 1 & HIT ENTER TO - VIEW FRIENDS");
            Console.WriteLine("TYPE: 2 & HIT ENTER TO - ADD FRIEND");
            Console.WriteLine("TYPE: 3 & HIT ENTER TO - EDIT FRIEND");
            Console.WriteLine("TYPE: 4 & HIT ENTER TO - REMOVE FRIEND");
            Console.WriteLine("TYPE: 5 & HIT ENTER TO - CHECk NEXT BDAY");
            Console.WriteLine("TYPE: 9 & HIT ENTER TO - EXIT");
            Console.WriteLine("###########################################################################");
        }

    }
}
