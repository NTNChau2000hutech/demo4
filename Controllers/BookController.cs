using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lap3.Models;
namespace Lap3.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public string HelloTeacher(string university)
        {
            return "Hello Nguyen Thi Ngoc Chau - University" + university;
        }
        public ActionResult ListBook(string unniversity)
        {
            List<string> listBook = new List<string>();
            listBook.Add("HTML % CSSS the complete Manual-Author Name Book 1");
            listBook.Add("HTML % CSSS the complete Manual-Author Name Book 2");
            listBook.Add("HTML % CSSS the complete Manual-Author Name Book 3");
            ViewBag.Books = listBook;
            return View();
        }
        public ActionResult ListBookMode()
        { 
            List<Book> listBook = new List<Book>();
            Book book1 = new Book(1, "Sach 1", "Tac gia 1", "/Content/Images/hinhanh1.jpg");
            listBook.Add(book1);
            listBook.Add(new Book(10,"sach 10","Tac gia 10", "/Content/Images/hinhanh10.jpg"));
            listBook.Add(new Book (100, "sach 100", "Tac gia 100", "/Content/Images/hinhanh100.jpg"));
            ViewBag.Books = listBook;
            return View();
        }

    }
}