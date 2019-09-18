using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Indecor.Models
{
    public class Product
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Required"), StringLength(300, ErrorMessage = "Length can't be more than 300")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required"), StringLength(300, ErrorMessage = "Length can't be more than 300")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Required"), StringLength(5000, ErrorMessage = "Length can't be more than 5000")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Required")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Required")]
        public int Count { get; set; }
        [Required(ErrorMessage = "Required"), StringLength(255, ErrorMessage = "Length can't be more than 255")]
        public string Image  { get; set; }

        public int DiscountProduct { get; set; }

        public DateTime? ProductDedline { get; set; }

       
        public bool NewProduct { get; set; }

      
        public int MostView { get; set; }

        
        public int SellerCount { get; set; }
        public string Active { get; set; }
                
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Required")]
        public IFormFile Photo { get; set; }

        [NotMapped]
        public IFormFile UpdateProduct { get; set; }




    }
}
