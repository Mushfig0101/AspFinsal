using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Indecor.ViewModels
{
    public class ProductViewModel
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

        public int DiscountProduct { get; set; }

        
        public DateTime? Deadline { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Required")]
        public IFormFile Photo { get; set; }

    }
}
