using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service1
{
    public class TaskList
    {
        private string name;
        private List<Task> tasks;

        /// <summary>
        /// Создает объект
        /// </summary>
        /// <param name="name"></param>

        public TaskList (string name)
        {
            this.name = name;
            tasks = new List<Task>();
        }

        /// <summary>
        /// Возвращает имя списка
        /// </summary>
        /// <returns></returns>

        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Добавляет задачу в список
        /// </summary>
        /// <param name="task"></param>

        public void AddTask (Task task)
        {
            tasks.Add(task);
        }

        public List<Task> GetTasks()
        {
            return tasks;
        }
        
        public void Remove (Task task)
        {
            tasks.Remove(task);
        }

        public List <Task> GetTasksByToday()
        {
            List<Task> tasksByToday = new List<Task>();

            foreach (var task in tasks)
            {
                if (task.Due == DateTime.Now)
                {
                    tasksByToday.Add(task);
                }
            }

            return tasksByToday;
        }

        public List<Task> GetTasksByFuture()
        {
            List<Task> tasksByToday = new List<Task>();

            foreach (var task in tasks)
            {
                if(task.Due > DateTime.Now)
                {
                    tasksByToday.Add(task);
                }
            }

            return tasksByToday;
        }
    }
}
