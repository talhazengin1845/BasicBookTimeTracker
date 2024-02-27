using System;
using Microsoft.AspNetCore.Mvc;
using WebApplicationProject.Models;
using Microsoft.VisualBasic;

namespace WebApplicationProject.Controllers
{
    public class BookController : Controller
    {
        // GET: /<controller>/

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hello(string name, string author, int page_number, DateTime due_date, int a)
        {
            Book book = new Book();
            book.bookName = name;
            book.author = author;
            book.pageNumber = page_number;
            book.dueDate = due_date;
            ///book.remainingTime = remainingTime;
            DateTime now = DateTime.Now;
            ///remainingTime = due_date - now;

            TimeSpan remainingTime = due_date - now;
            ///a = remainingTime.TotalDays;
            book.remainingTime = remainingTime;
            return View(book);
        }
    }
}
