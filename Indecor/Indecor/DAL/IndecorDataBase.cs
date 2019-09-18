using Indecor.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Indecor.DAL
{
    public class IndecorDataBase:IdentityDbContext<UserControl>
    {
        public IndecorDataBase(DbContextOptions<IndecorDataBase> options) : base(options)
        {
                
        }
           public DbSet<BigSlider> BigSliders { get; set; }
           public DbSet<WeekCategory> WeekCategories { get; set; }
           public DbSet<Category> Categories { get; set; }

           public DbSet<Product> Products { get; set; }
           public DbSet<AltSlider> AltSliders { get; set; }
           public DbSet<Brand> Brands { get; set; }
          public DbSet<Blog> Blogs { get; set; }

    }
}
 