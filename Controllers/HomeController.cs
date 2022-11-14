using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        TodoListViewModel = GetAllTodos();
        return View();
    }

    internal TodoViewModel GetAllTodos()
    {
        List<Task> todoList = new();

        using (SqlLiteConnection con =
            new SqliteConnection("Data Source=db.sqlite"))
        {
            using (var tableCmd = con.CreateCommand())
            {
                con.Open();
                tableCmd.CommandText = "SELECT * FROM todo";

                using (var reader = tableCmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            todoList.Add(new Task
                            {
                                Id = reader.GetInt32(0),
                                TaskTitle = reader.GetString(1)
                            });
                        }
                    }
                }
            }
        }
    }

}
