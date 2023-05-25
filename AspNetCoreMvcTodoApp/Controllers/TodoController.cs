using AspNetCoreMvcTodoApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class TodoController : Controller
{
    private static List<Todo> todos = new List<Todo>();

    // GET: Todo
    public ActionResult Index()
    {
        return View(todos);
    }

    // GET: Todo/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: Todo/Create
    [HttpPost]
    public ActionResult Create(Todo todo)
    {
        if (ModelState.IsValid)
        {
            todo.Id = todos.Count + 1;
            todos.Add(todo);
            return RedirectToAction("Index");
        }

        return View(todo);
    }

    // POST: Todo/Delete/5
    [HttpPost]
    public ActionResult Delete(int id)
    {
        var todo = todos.FirstOrDefault(t => t.Id == id);
        if (todo != null)
        {
            todos.Remove(todo);
        }

        return RedirectToAction("Index");
    }
}

