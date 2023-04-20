using FPT_Book.Data;
using Microsoft.AspNetCore.Mvc;

namespace FPT_Book.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly AppDBContext _context;

        public AuthorsController(AppDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Authors.ToList();
            return View("AuthorIndex", data);
        }
    }
}
