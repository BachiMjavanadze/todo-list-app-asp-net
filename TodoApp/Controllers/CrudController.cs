using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Data;
using TodoApp.Models;
using System.Web;

namespace TodoApp.Controllers;
public class CrudController : Controller
{
    private readonly ApplicationDbContext _db;

    public CrudController(ApplicationDbContext db)
    {
        _db = db;
    }


    // GET: CrudController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: CrudController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Todo obj)
    {
        if (ModelState.IsValid)
        {
            _db.Todos.Add(obj);
            _db.SaveChanges();
            TempData["success"] = "ToDo created successfully!";
            return RedirectToAction("Index", "Home");
        }

        return View(obj);
    }

    // GET: CrudController/Edit
    public ActionResult Edit(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        var TodoFromDb = _db.Todos.FirstOrDefault(x => x.Id == id);

        if (TodoFromDb == null)
        {
            return NotFound();
        }

        return View(TodoFromDb);
    }

    // POST: CrudController/Edit
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(Todo obj)
    {
        if (ModelState.IsValid)
        {
            _db.Todos.Update(obj);
            _db.SaveChanges();
            TempData["success"] = "ToDo Updated successfully!";
            return RedirectToAction("Index", "Home");
        }

        return View(obj);
    }

    // GET: CrudController/Delete
    public ActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        var TodoFromDb = _db.Todos.FirstOrDefault(x => x.Id == id);

        if (TodoFromDb == null)
        {
            return NotFound();
        }

        return View(TodoFromDb);
    }

    // POST: CrudController/Delete
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult DeletePost(int? id)
    {
        var obj = _db.Todos.FirstOrDefault(x => x.Id == id);

        if (obj==null)
        {
            return NotFound();
        }

        _db.Todos.Remove(obj);
        _db.SaveChanges();
        TempData["success"] = "ToDo Deleted successfully!";
        return RedirectToAction("Index", "Home");
    }
}
