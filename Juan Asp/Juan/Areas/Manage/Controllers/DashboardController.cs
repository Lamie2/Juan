using Juan.DAL;
using Juan.Models;
using Juan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class DashboardController : Controller
    {
        private AppDbContext _context;
        public DashboardController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
