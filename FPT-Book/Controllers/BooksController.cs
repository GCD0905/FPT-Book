using FPT_Book.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FPT_Book.Controllers
{
    public class BooksController : Controller
    {
        private readonly AppDBContext _context;

        public BooksController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allBooks = await _context.Books.Include(n => n.Bookstore).OrderBy(n => n.Name).ToListAsync();
            return View("BookIndex", allBooks);
        }
    }
}
