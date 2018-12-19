using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TeisterMask.Data;
using TeisterMask.Models;

namespace TeisterMask.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            using (var db = new TeisterMaskDbContext())
            {
                var allTasks = db.Tasks.ToList();
                return View(allTasks);
            }

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string title, string status)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(status))
            {
                return RedirectToAction("Index");
            }

            Task task = new Task();
            task.Title = title;
            task.Status = status;

            using (var db = new TeisterMaskDbContext())
            {
                db.Add(task);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new TeisterMaskDbContext())
            {
                Task taskToEdite = db.Tasks.FirstOrDefault(t => t.Id == id);

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

            using (var db = new TeisterMaskDbContext())
            {
                var taskToEdit = db.Tasks.FirstOrDefault(t => t.Id == task.Id);
                taskToEdit.Title = task.Title;
                taskToEdit.Status = task.Status;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new TeisterMaskDbContext())
            {
                var taskToDelete = db.Tasks.FirstOrDefault(t => t.Id == id);
                if (taskToDelete == null)
                {
                    return RedirectToAction("Index");
                }

                return View(taskToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete (Task task)
        {
            using (var db = new TeisterMaskDbContext())
            {
                var taskToDelete = task;

                
                db.Remove(taskToDelete);
                db.SaveChanges();
                
                return RedirectToAction("Index");
            }
        }
    }
}
