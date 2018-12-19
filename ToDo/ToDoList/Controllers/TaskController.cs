using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            using (var db = new ToDoDbContext())
            {
                var allTasks = db.Tasks.ToList();
                return View(allTasks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(string title, string comments)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(comments))
            {
                return RedirectToAction("Index");
            }

            Task task = new Task();
            task.Title = title;
            task.Comments = comments;

            using (var db = new ToDoDbContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new ToDoDbContext())
            {
                var taskToEdite = db.Tasks.FirstOrDefault(t => t.Id == id);
                if (taskToEdite == null)
                {
                    return RedirectToAction("Index");
                }

                return View(taskToEdite);
            }
        }

        [HttpPost]
        public IActionResult Edit(Task task)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            using (var db = new ToDoDbContext())
            {
                var taskToEdite = db.Tasks.FirstOrDefault(t => t.Id == task.Id);
                taskToEdite.Title = task.Title;
                taskToEdite.Comments = task.Comments;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            using (var db = new ToDoDbContext())
            {
                Task taskDetails = db.Tasks.FirstOrDefault(t => t.Id == id);

                if (taskDetails==null)
                {
                    return RedirectToAction("Index");
                }

                return View(taskDetails);
            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            using (var db = new ToDoDbContext())
            {
                Task taskDelete = db.Tasks.FirstOrDefault(t => t.Id == id);

                if (taskDelete==null)
                {
                    return RedirectToAction("Index");
                }

                db.Remove(taskDelete);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
