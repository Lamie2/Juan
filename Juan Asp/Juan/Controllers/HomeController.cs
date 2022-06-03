using Juan.DAL;
using Juan.Models;
using Juan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
           
        List<Slider> sliders = _context.Sliders.ToList();
            HomeViewModel HomeVM = new HomeViewModel
            {
                Sliders = sliders
            } ;
            return View(HomeVM);
        }
    }
}
