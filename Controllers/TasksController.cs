using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace TodoApp.Controllers;

public class TasksController : Controller
{
    public string Index()
    {
        return "This is my default action.. ";
    }
    public string Welcome()
    {
        return "Thsi is the Welcome action method ...";
    }
}