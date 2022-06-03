using Juan.DAL;
using Juan.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Areas.Manage.Controllers
{
    [Area("manage")]
    public class PolicyController : Controller
    {
        private readonly JuanDbContext _context;

        public PolicyController(JuanDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            List<Policy> policies = _context.Policies.ToList();
            return View(policies);
        }
    }
}
