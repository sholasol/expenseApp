using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpenseApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExpenseApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            return _context.Categories != null ?
                View(await _context.Categories.ToListAsync()) :
                Problem("Entity set 'ApplicationDbContext.Categories' is null");
        }

        public async Task<IActionResult> Create([Bind("CategoryId, Titile, Icon, type")] Category category)
        {
            if (ModelState.IsValid)
            {
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }


    }
}

