using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service1
{
    public class Task
    {
        /// <summary>
        /// Название задачи
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Дата и время завершения выполнения задачи
        /// </summary>
        public DateTime Due { get; set; }
    }
}
