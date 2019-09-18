using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Indecor.DAL;
using Indecor.Extensions;
using Indecor.Models;
using Indecor.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Indecor.Areas.Indecor.Controllers
{
    [Area("Indecor")]
    public class ProductController : Controller
    {
        private IndecorDataBase _db;
        private IHostingEnvironment _env;

        public ProductController(IndecorDataBase indecorDataBase, IHostingEnvironment hostingEnvironment)
        {
            _db = indecorDataBase;
            _env = hostingEnvironment;
        }
        public IActionResult Index()
        {
          
            return View(_db.Products);

        }

        public IActionResult Create()
        {
            CreateProduct created = new CreateProduct()
            {
                Products = _db.Products,
               m = new List<Category>() { }


            };
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Product newproduct)
        {
            

            if (ModelState["Name"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Title"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Description"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Count"].ValidationState == ModelValidationState.Invalid ||
                ModelState["DiscountProduct"].ValidationState == ModelValidationState.Invalid ||
                ModelState["ProductDedline"].ValidationState == ModelValidationState.Invalid ||
                 ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return RedirectToAction(nameof(Index));
            }

            if (newproduct.Photo != null)
            {
                if (!newproduct.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "You can chose only image format");
                    return View();
                }

                if (!newproduct.Photo.CheckSize(2))
                {
                    ModelState.AddModelError("Photo", "You can chose only small 2 MB");
                    return View();
                }

                if (newproduct.DiscountProduct == 0)
                {
                    newproduct.ProductDedline = null;
                }
                string createdImage = await newproduct.Photo.CopyImage(_env.WebRootPath, "product");

                //Product product = new Product()
                //{
                //    Name = newproduct.Name,
                //    Title = newproduct.Title,
                //    Description = newproduct.Description,
                //    Price = newproduct.Price,
                //    Count = newproduct.Count,
                //    DiscountProduct = newproduct.DiscountProduct,
                //    ProductDedline = newproduct.Deadline,
                //    NewProduct = true,
                //    MostView = 0,
                //    SellerCount = 0,
                //    Active = null

                //};

                newproduct.Image = createdImage;
                // return Content($"{newproduct.Image}");
                await _db.Products.AddAsync(newproduct);


            }

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }
    }
}