using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokTask.Models;
using PustokTask.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokTask.Controllers
{
    public class BookController : Controller
    {
        private readonly PustokContext _context;

        public BookController(PustokContext context)
        {
            _context = context;
        }
        public IActionResult GetBook(int id)
        {
            Book book = _context.Books.Include(x => x.Genre).Include(x=>x.Author).Include(x=>x.BookImages).FirstOrDefault(x => x.Id == id);


            return PartialView("_ModalPartialView", book);
        }

        public IActionResult Index()
        {

            BookViewModel bookvm = new BookViewModel
            {
                Books = _context.Books.Include(x => x.Genre).Include(x => x.Author).Include(x => x.BookImages).ToList(),
                Genres = _context.Genres.ToList()             
            };
            return View(bookvm);

            
        }
        public IActionResult GetBookbyGenre(int id)
        {
            List<Book> books = _context.Books.Include(x => x.Genre).Include(x => x.Author).Include(x => x.BookImages).Where(x=>x.GenreId == id).ToList();

            return PartialView("_BookProducts", books);
        }
    }
}
