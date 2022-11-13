using Microsoft.AspNetCore.Mvc; //it has controller class
using ShahzaibBooksStore.Models;
using ShahzaibBooksStore.Repository;
using System.Collections.Generic;

namespace ShahzaibBooksStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }


        public IActionResult Index()
        {
            return View();
        }

        public ViewResult GetBooks()  //domain/book/getbooks
        {
            var data = _bookRepository.GetAllBooks();
            return View();
        }

        public BookModel GetthisBook(int id) //domain/book/getthisbook/2
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBooks(string bookName, string authorName) //domain/book/searchbooks?bookName=Harry Potter&authorName=JK Rowling    
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
