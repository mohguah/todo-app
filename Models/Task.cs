using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }

        public Task()
        {
        }

        // public Task(string TaskTitle, string TaskDescription)
        // {
        //     this.TaskTitle = TaskTitle;
        //     this.TaskDescription = TaskDescription;
        // }
    }
}