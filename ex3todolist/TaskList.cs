using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3todolist
{
    public class TaskList
    {
        public List<Task> MojaLista { get; set; } = new List<Task>();
        public void AddTask(string description, int chujwieco)
        {
            var newTask = new Task();
            newTask.Description = description;
            newTask.Priority = chujwieco;
            MojaLista.Add(newTask);
        }
        public void RemoveTask(int indeks)
        {
            if (indeks < MojaLista.Count() && indeks >= 0)
            {

                MojaLista.RemoveAt(indeks);
            }
            else if (indeks >= MojaLista.Count())
            {
                Console.WriteLine("There is no such record in todo tasks list.");
            }

        }
        public void EditTask(string descritption, int priority)
        {
            var eelementOfMojaLista = MojaLista.Where(x => x.Description.ToLower() == descritption.ToLower() && x.Priority == priority).FirstOrDefault();
            if (eelementOfMojaLista != null)
            {
                eelementOfMojaLista.Description = descritption;
                eelementOfMojaLista.Priority = 5;
            }
        }

        public int GetCount()
        {
            return this.MojaLista.Count();
        }
    }
}
