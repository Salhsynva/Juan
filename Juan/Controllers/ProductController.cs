using Juan.DAL;
using Juan.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Controllers
{
    public class ProductController : Controller
    {
        private readonly JuanDbContext _context;

        public ProductController(JuanDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index(int id)
        {
            Product product = _context.Products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }
    }
}
