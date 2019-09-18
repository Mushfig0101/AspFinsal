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
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Indecor.Areas.Indecor.Controllers
{
    [Area("Indecor")]
    public class BrandController : Controller
    {
        private IndecorDataBase _db;
        private IHostingEnvironment _env;

        public BrandController(IndecorDataBase indecorDataBase, IHostingEnvironment hostingEnvironment)
        {
            _db = indecorDataBase;
            _env = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View(_db.Brands);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Brand brand = await _db.Brands.FindAsync(id);
            if (brand == null) return NotFound();
            return View(brand);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Brand brand)
        {
            if (!brand.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "You can chose only image format");
            }


            if (!brand.Photo.CheckSize(2))
            {
                return View();
            }

            string createdImage = await brand.Photo.CopyImage(_env.WebRootPath, "brand");
            brand.Path = createdImage;

            await _db.Brands.AddAsync(brand);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Brand brand = await _db.Brands.FindAsync(id);
            if (brand == null) return NotFound();
            return View(brand);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return Content("Id tapilmadiq");
            Brand brand = await _db.Brands.FindAsync(id);
            if (brand == null) return NotFound();

            Assistant.DeleteFromFolder(_env.WebRootPath, brand.Path);

            _db.Brands.Remove(brand);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //RedirectToAction(nameof(Index))
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Brand brand = await _db.Brands.FindAsync(id);
            if (brand == null) return NotFound();
            return View(brand);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Brand brand)
        {
            if (id == null) return NotFound();
            Brand dbbrand = await _db.Brands.FindAsync(id);
            if (brand == null) return NotFound();
            //if (dbbrand.Id != null) return Content($"{dbbrand.Id}");

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return RedirectToAction(nameof(Index));
            }

            if (brand.Photo != null)
            {
                if (!brand.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "You can Cchose only image");
                    return View();
                }

                if (!(brand.Photo.CheckSize(2)))
                {
                    ModelState.AddModelError("Photo", "You Can choos Image a little than 2 MB");
                    return View();
                }

                string createdPath = await brand.Photo.CopyImage(_env.WebRootPath, "brand");
                Assistant.DeleteFromFolder(_env.WebRootPath, dbbrand.Path);
                dbbrand.Path = createdPath;

            }

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }


    }
}
