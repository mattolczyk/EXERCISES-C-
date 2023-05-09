using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2birthdays
{
    public class FriendList
    {
        public List<Friend> myList { get; set; } = new List<Friend>();

        public void AddFriend(string fullName, DateTime birthDate)
        {
            var newTask = new Friend();
            newTask.FullName = fullName;
            newTask.BirthDay = birthDate;
            myList.Add(newTask);
        }
        public void RemoveFriend(int indeks)
        {
            if (indeks < myList.Count() && indeks >= 0)
            {
                myList.RemoveAt(indeks);
                Console.WriteLine("FRIEND DATA REMOVED FROM LIST.");
            }
            else if (indeks >= myList.Count())
            {
                Console.WriteLine("There is no such record in FRIENDS list.");
            }
        }

        public void EditFriendFname(int indeks, string fullNameNew)
        {
            if (indeks < myList.Count() && indeks >= 0)
            {
                myList[indeks].FullName = fullNameNew;
                Console.WriteLine("FRIEND FULL NAME EDITED SUCCESFULLY!");
            }
            else if (indeks >= myList.Count())
            {
                Console.WriteLine("There is no such record in FRIENDS list.");
            }
        }
        public void EditFriendBday(int indeks, string birthDateNew)
        {
            if (indeks < myList.Count() && indeks >= 0)
            {
                var inputtedDate = new DateTime(2022, 5, 05);
                if (DateTime.TryParse(birthDateNew, out inputtedDate))
                {
                    myList[indeks].BirthDay = inputtedDate;
                    Console.WriteLine("FRIEND BIRTH DAY EDITED SUCCESFULLY!");
                }
                else
                {
                    Console.WriteLine("NO CHANGES HAS BEEN MADE. You have entered an incorrect value. ");
                }
            }
            else if (indeks >= myList.Count())
            {
                Console.WriteLine("There is no such record in friends list.");
            }
        }
        public void ListFriends()
        {
            foreach (var leFriend in myList)
            {
                Console.WriteLine(leFriend.FullName + " " + leFriend.BirthDay);
            }
        }
    }
}
