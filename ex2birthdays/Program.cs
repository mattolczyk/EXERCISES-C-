using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ex2birthdays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var leFriendsList = new FriendList();
            var Menu = new Menu();
            leFriendsList.myList = new List<Friend>();

            //POPULATE LIST WITH SAMPLE FRIENDS DATA
            var fakeDate = new DateTime(2022, 5, 05);
            leFriendsList.AddFriend("John Smith", fakeDate);
            leFriendsList.AddFriend("Elton John", fakeDate.AddMonths(2));
            leFriendsList.AddFriend("Michael Jackson", fakeDate.AddMonths(-2));


            while (true)
            {
                int howManyFriends = Convert.ToInt32(leFriendsList.myList.Count());

                Menu.ShowMenu();

                var op = Console.ReadLine();
                if (op.Equals("1"))
                {
                    Console.Clear();
                    Console.WriteLine(" ############################### YOUR FRIENDS LIST ############################### ");
                    leFriendsList.ListFriends();
                } 
                if (op.Equals("2"))
                {
                    Console.WriteLine("Provide Full Name: ");
                    var fullName = Console.ReadLine();

                    Console.Write("Enter a date of birth (e.g. 10/22/1987): ");
                    //DateTime inputtedDate = DateTime.Parse(Console.ReadLine());

                    var inputtedDate = new DateTime(2022, 5, 05);
                    if (DateTime.TryParse(Console.ReadLine(), out inputtedDate))
                    {
                        leFriendsList.AddFriend(fullName, inputtedDate);
                        Console.WriteLine("FRIEND ADDED TO LIST. You have entered an correct value. ");
                    }
                    else
                    {
                        Console.WriteLine("NO FRIEND ADDED TO LIST. You have entered an incorrect value. ");
                    }

                }
                if (op.Equals("3"))
                {
                    Console.Clear();
                    leFriendsList.ListFriends();
                    Console.WriteLine("Which friend's data would you like to EDIT? Current number of friend(s) record(s): " + howManyFriends);

                    var indeks = Console.ReadLine();
                    if (!int.TryParse(indeks, out int editedIndex))
                    {
                        Console.WriteLine($"{indeks} is not a number");
                    }
                    else
                    {
                        Console.WriteLine("TYPE: 1 & HIT ENTER TO - EDIT FULL NAME OF: " + leFriendsList.myList[editedIndex-1].FullName);
                        Console.WriteLine("TYPE: 2 & HIT ENTER TO - EDIT BIRTH DAY DATE OF: " + leFriendsList.myList[editedIndex-1].FullName);
                        Console.WriteLine("HIT ANY KEY TO - ABORT EDIT");

                        var op3 = Console.ReadLine();
                        if (op3.Equals("1"))
                        {
                            Console.WriteLine("Provide NEW Full Name : ");
                            var newName = Console.ReadLine();
                            leFriendsList.EditFriendFname((editedIndex - 1), newName);
                        }
                        if (op3.Equals("2"))
                        {
                            Console.Write("Provide NEW  date of birth (e.g. 10/22/1987): ");
                            var newDate = Console.ReadLine();
                            leFriendsList.EditFriendBday((editedIndex - 1), newDate);
                        }
                    }
                }
                if (op.Equals("4"))
                {
                    Console.Clear();
                    leFriendsList.ListFriends();
                    Console.WriteLine("Which friend's data would you like to DELETE? Current number of friend(s) record(s): " + howManyFriends);
                    
                    var indeks = Console.ReadLine();
                    if (!int.TryParse(indeks, out int editedIndex))
                    {
                        Console.WriteLine($"{indeks} is not a number");
                    }

                    else
                    {
                        leFriendsList.RemoveFriend(editedIndex - 1);
                    }

                }
                if (op.Equals("5"))
                {
                    int currentclosest = 366;
                    string nextBdayPerson = "nobody";
                    foreach (var leFriend in leFriendsList.myList)
                    {
                        DateTime todaydate = DateTime.Today;
                        DateTime nextdate = new DateTime(todaydate.Year, (leFriend.BirthDay).Month, (leFriend.BirthDay).Day);

                        if (nextdate < todaydate)
                        {
                            nextdate = nextdate.AddYears(1);
                        }
                        int numDays = (nextdate - todaydate).Days;

                        if (numDays <= currentclosest)
                        {
                            currentclosest = numDays;
                            nextBdayPerson = leFriend.FullName;
                        }
                        //Console.WriteLine(leFriend.FullName + " " + leFriend.BirthDay);
                        //Console.WriteLine("Days to birthday: " + numDays);
                    }
                    Console.Clear();
                    Console.WriteLine(" ############################### NEXT BDAY ############################### ");
                    Console.WriteLine("Remember about next Bday of: " + nextBdayPerson);
                    Console.WriteLine("There's only " + currentclosest + " day(s) left!");
                }
                if (op.Equals("9"))
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}




