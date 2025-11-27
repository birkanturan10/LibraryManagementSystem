using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.UI.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            var books = _bookService.GetAll();
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.Add(book);

                return RedirectToAction("Index");
            }

            return View(book);
        }
    }
}
