using FPT_Book.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FPT_Book.Controllers
{
    public class PublishersController : Controller
    {
        private readonly AppDBContext _context;

        public PublishersController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allPublishers = await _context.Publishers.ToListAsync();
            return View("PublisherIndex", allPublishers);
        }
    }
}
