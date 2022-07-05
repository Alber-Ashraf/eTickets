using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinemasContoller : Controller
    {
        private readonly AppDbContext _context;

        public CinemasContoller(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.Cenimas.ToListAsync();
            return View();
        }
    }
}
