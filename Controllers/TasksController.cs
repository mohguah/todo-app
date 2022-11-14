using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using TodoApp.Data;

namespace TodoApp.Controllers;

public class TasksController : Controller
{
    // private readonly ApplicationDbContext _context;

    // public JokesController(ApplicationDbContext context)
    // {
    //     _context = context;
    // }

    // public async Task<IActionResult> Index()
    // {
    //     return _context.Task != null ?
    //         View(await _context.Task.ToListAsync()) :
    //         Problem("Entity set 'ApplicationDbContext.Task' is null");
    // }

    public string Index() {
        return "Details.cshtml";
    }
    public string Welcome()
    {
        return "Thsi is the Welcome action method ...";
    }
}