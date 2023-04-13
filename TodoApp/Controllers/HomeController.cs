using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Controllers;
public class HomeController : Controller
{
    private readonly ApplicationDbContext _db;

    public HomeController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult ReturnView(IEnumerable<Todo> objTodoList)
    {
        if (objTodoList is null)
        {
            throw new ArgumentNullException(nameof(objTodoList), "Arguemnt is null");
        }

        objTodoList = _db.Todos;
        return View(objTodoList);
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult All()
    {
       return ReturnView(_db.Todos);
    }

    public IActionResult NotStarted()
    {
        return ReturnView(_db.Todos);
    }

    public IActionResult InProgress()
    {
        return ReturnView(_db.Todos);
    }

    public IActionResult Completed()
    {
        return ReturnView(_db.Todos);
    }

    public IActionResult Hidden()
    {
        return ReturnView(_db.Todos);
    }
}
