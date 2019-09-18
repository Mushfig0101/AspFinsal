using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Indecor.Models;
using Indecor.DAL;
using Indecor.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Indecor.Controllers
{
    public class HomeController : Controller
    {
        private IndecorDataBase _dbIndecor;
        public HomeController(IndecorDataBase indecorDataBase)
        {
            _dbIndecor = indecorDataBase;

        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                BigSliders = _dbIndecor.BigSliders,
                WeekCategories = _dbIndecor.WeekCategories,
                Products = _dbIndecor.Products,
                AltSliders = _dbIndecor.AltSliders,
                Brands = _dbIndecor.Brands,
                Blogs = _dbIndecor.Blogs,
                Categories = _dbIndecor.Categories.Include(x => x.Product)
                
                
            };
             ViewBag.Count = _dbIndecor.WeekCategories.Count();

            return View(homeViewModel);
        }
          
        
    }
}
