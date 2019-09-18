using System;
using System.Collections.Generic;
using System.IO;
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
    public class BigSliderController : Controller
    {
        private IndecorDataBase _db;
        private IHostingEnvironment _env;
        public BigSliderController(IndecorDataBase indecorDataBase, IHostingEnvironment hostingEnvironment)
        {
            _db = indecorDataBase;
            _env = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View(_db.BigSliders);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            BigSlider bigSlider = await _db.BigSliders.FindAsync(id);
            if (bigSlider == null) return NotFound();
            return View(bigSlider);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BigSlider bigSlider)
        {

            if (ModelState["Title"].ValidationState == ModelValidationState.Invalid
                || ModelState["Description"].ValidationState == ModelValidationState.Invalid
                || ModelState["Link"].ValidationState == ModelValidationState.Invalid
                || ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {

                return View();
                
            }

            if (bigSlider.Photo != null)
            {
                if (!bigSlider.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "You can chose only image format");
                    return View();
                }


                if (!bigSlider.Photo.CheckSize(2))
                {
                    ModelState.AddModelError("Photo", "You can chose only small 2 MB");
                    return View();
                }

                string createdImage = await bigSlider.Photo.CopyImage(_env.WebRootPath, "slider");
                bigSlider.Image = createdImage;
                await _db.BigSliders.AddAsync(bigSlider);
            }

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult>  Delete(int? id)
        {
            if (id == null) return NotFound();
            BigSlider bigSlider = await _db.BigSliders.FindAsync(id);
            if (bigSlider == null) return NotFound();
            return View(bigSlider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult>  DeletePost(int? id)
        {
            if (id == null) return NotFound();
            BigSlider bigSlider = await _db.BigSliders.FindAsync(id);
            if (bigSlider == null) return NotFound();

            Assistant.DeleteFromFolder(_env.WebRootPath, bigSlider.Image);
            _db.BigSliders.Remove(bigSlider);
            await  _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            BigSlider bigSlider = await _db.BigSliders.FindAsync(id);
            if (bigSlider == null) return NotFound();
            return View(bigSlider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, BigSlider bigSlider)
        {
            if (id == null) return NotFound();
            BigSlider dbBigSlider = await _db.BigSliders.FindAsync(id);
            if (bigSlider == null) return NotFound();

            if (ModelState["Title"].ValidationState == ModelValidationState.Invalid
                || ModelState["Description"].ValidationState == ModelValidationState.Invalid
                || ModelState["Link"].ValidationState == ModelValidationState.Invalid) {
          
                return View(bigSlider);
            }

            if (bigSlider.UpdatePhoto != null)
            {
                if (!bigSlider.UpdatePhoto.IsImage())
                {
                    ModelState.AddModelError("UpdatePhoto", "You can choose only Image Format");
                    return View();
                }
                if (!bigSlider.UpdatePhoto.CheckSize(2))
                {
                    ModelState.AddModelError("UpdatePhoto", "You can choosen only small at 2mb");
                    return View();
                }

                string filename = await bigSlider.UpdatePhoto.CopyImage(_env.WebRootPath, "slider");
                Assistant.DeleteFromFolder(_env.WebRootPath, dbBigSlider.Image );
                dbBigSlider.Image = filename;
            }

            dbBigSlider.Title = bigSlider.Title;
            dbBigSlider.Description = bigSlider.Description;
            dbBigSlider.Link = bigSlider.Link;      
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
   
        }


    }

}

    
