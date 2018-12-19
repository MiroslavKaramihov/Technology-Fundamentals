using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new Data.LibraryDbContext())
            {
                List<Book> allBook = db.Books.ToList();

                return View(allBook);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (book.Title == null || book.Price == 0 || book.Author == null)
            {
                return RedirectToAction("Index");
            }

            var newBook = new Book();
            newBook.Title = book.Title;
            newBook.Author = book.Author;
            newBook.Price = book.Price;

            using (var db = new Data.LibraryDbContext())
            {
                db.Add(newBook);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new Data.LibraryDbContext())
            {
                Book book = db.Books.FirstOrDefault(x => x.Id == id);

                if (book == null)
                {
                    return RedirectToAction("Index");
                }
                return View(book);
            }
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new Data.LibraryDbContext())
            {
                var editetBook = db.Books.FirstOrDefault(x => x.Id == book.Id);

                editetBook.Author = book.Author;
                editetBook.Price = book.Price;
                editetBook.Title = book.Title;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new Data.LibraryDbContext())
            {
                var deletetBook = db.Books.FirstOrDefault(x => x.Id == id);

                return View(deletetBook);
            }
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            using(var db =new Data.LibraryDbContext())
            {
                book = db.Books.FirstOrDefault(x => x.Id == book.Id);
                db.Remove(book);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}