﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskmanager

{
    using System.Collections.Generic;

    public class TaskManager
    {
       
        private List<string> tasks = new List<string>();

        public void AddTask(string task)
        {
            // TODO: Uzupełnij implementację metody AddTask, aby dodawała nowe zadanie do listy.
            tasks.Add(task);

        }

        public void RemoveTask(string task)
        {
            // TODO: Uzupełnij implementację metody RemoveTask, aby usuwała zadanie z listy, jeśli istnieje.
            tasks.Remove(task);

        }

        public  void GetTasks(List<string> list)
        {
            // TODO: Uzupełnij implementację metody GetTasks, aby zwracała listę wszystkich zadań.
            Console.WriteLine("Lista zadań:");
            foreach (string task in list) 
            { 
                Console.WriteLine(task);
            }
            Console.WriteLine();
        }
       
    } 


}