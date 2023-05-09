using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3todolist
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var olczyktaskList = new TaskList();
            olczyktaskList.MojaLista = new List<Task>();



            olczyktaskList.AddTask("task", 1);
            olczyktaskList.AddTask("task2", 56);
            olczyktaskList.AddTask("task3", 666);


            // 1. VIEW TASKS 149
            // 2. ADD TASK 250
            // 3. EDIT TASK 351
            // 4. REMVOE TASK 452

            while (true)
            {
                var op = Console.ReadLine();

                if (op.Equals("1"))
                {
                    //        Console.WriteLine(olczyktaskList.MojaLista[0].Description);
                    foreach (var blabla in olczyktaskList.MojaLista)
                    {
                        Console.WriteLine(blabla.Description);
                    }

                }
                if (op.Equals("2"))
                {
                    Console.WriteLine("Provide description");
                    var description = Console.ReadLine();
                    Console.WriteLine("Provide priority rating - digit > 0 !!!");

                    int priority = 0;
                    while (priority == 0)
                    {
                        int.TryParse(Console.ReadLine(), out priority);
                        Console.WriteLine(priority);
                        if (priority <= 0)
                        {
                            Console.WriteLine("Wrong data - please provide digit bigger than zero");
                        }
                    }

                    olczyktaskList.AddTask(description, priority);
                }

                if (op.Equals("4"))
                {
                    Console.WriteLine("Which task would you like to delate - counted from 0.");
                    olczyktaskList.RemoveTask(Convert.ToInt32(Console.ReadLine()));

                }

            }


            //if (operation = "1") { Console.WriteLine};
            //Console.WriteLine(olczyktaskList.GetCount());

        }
    }
}
