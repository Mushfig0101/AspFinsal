using Indecor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Indecor.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<BigSlider> BigSliders { get; set; }
        public IEnumerable<WeekCategory> WeekCategories { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<AltSlider> AltSliders { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }

    }
}
