using FPT_Book.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FPT_Book.Controllers
{
    public class BookStoresController : Controller
    {
        private readonly AppDBContext _context;

        public BookStoresController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allBookStores = await _context.Bookstores.ToListAsync();
            return View("BookStoreIndex", allBookStores);
        }
    }
}
