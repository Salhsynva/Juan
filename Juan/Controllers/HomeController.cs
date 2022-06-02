using Juan.DAL;
using Juan.Entities;
using Juan.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Controllers
{
    public class HomeController : Controller
    {
        private readonly JuanDbContext _context;

        public HomeController(JuanDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            List<Policy> policies = _context.Policies.ToList();
            List<Product> products = _context.Products.ToList();
            HomeViewModels homeVM = new HomeViewModels()
            {
                Sliders = sliders,
                Policies = policies,
                Products = products
            };

            return View(homeVM);
        }
    }
}
