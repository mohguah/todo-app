using System.Collections.Generic;

namespace TodoApp.Models
{
    public class TodoViewModel
    {
        public List<Task> TodoList { get; set; }
        public Task Todo { get; set; }
    }
}