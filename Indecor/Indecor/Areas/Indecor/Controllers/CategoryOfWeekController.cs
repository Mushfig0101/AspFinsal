using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Indecor.Assistants;
using Indecor.DAL;
using Indecor.Extensions;
using Indecor.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Indecor.Areas.Indecor.Controllers
{
    [Area("Indecor")]
    public class CategoryOfWeekController : Controller
    {
        private IndecorDataBase _db;
        private IHostingEnvironment _env;
        public CategoryOfWeekController(IndecorDataBase indecorDataBase, IHostingEnvironment hostingEnvironment)
        {
            _db = indecorDataBase;
            _env = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View(_db.WeekCategories);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            WeekCategory weekCategory = await _db.WeekCategories.FindAsync(id);
            if (weekCategory == null) return NotFound();
            return View(weekCategory);
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(WeekCategory weekcategory)
        {
            if (!weekcategory.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "You can chose only image format");
            }


            if (!weekcategory.Photo.CheckSize(2))
            {
                return View();
            }

            string createdImage = await weekcategory.Photo.CopyImage(_env.WebRootPath, "banner");
            weekcategory.Image = createdImage;

            await _db.WeekCategories.AddAsync(weekcategory);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            WeekCategory weekcategory = await _db.WeekCategories.FindAsync(id);
            if (weekcategory == null) return NotFound();
            return View(weekcategory);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return Content("Id tapilmadiq");
            WeekCategory weekcategory = await _db.WeekCategories.FindAsync(id);
            if (weekcategory == null) return NotFound();

            Assistant.DeleteFromFolder(_env.WebRootPath, weekcategory.Image);
            _db.WeekCategories.Remove(weekcategory);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            WeekCategory weekCategory = await _db.WeekCategories.FindAsync(id);
            if (weekCategory == null) return NotFound();
            return View(weekCategory);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id, WeekCategory weekCategory)
        {
            if (id == null) return NotFound();
            WeekCategory dbweekCategory = await _db.WeekCategories.FindAsync(id);
            if (weekCategory == null) return NotFound();

            if (weekCategory.Photo == null)
            {
                ModelState.AddModelError("Photo", "You can choose which of Image");
                return View();
            } 

            if (!weekCategory.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "You can choose only Image Format");
                return View();
            }

            if (!weekCategory.Photo.CheckSize(2))
            {
                ModelState.AddModelError("Photo", "You can choosen only small at 2mb");
                return View();
            }

            string filename = await weekCategory.Photo.CopyImage(_env.WebRootPath, "banner");
            Assistant.DeleteFromFolder(_env.WebRootPath, dbweekCategory.Image);
            dbweekCategory.Image = filename;

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

      
    }
}