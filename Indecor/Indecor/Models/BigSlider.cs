using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Indecor.Models
{
    public class BigSlider
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Required"), StringLength(300, ErrorMessage = "Length can't be more than 500")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Required"), StringLength(500, ErrorMessage = "Length can't be more than 500")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Required"), StringLength(250, ErrorMessage = "Length can't be more than 250")]
        public string Link { get; set; }

        [Required(ErrorMessage = "Required"), StringLength(250, ErrorMessage = "Length can't be more than 250")]
        public string Image { get; set; }

        [NotMapped]
        [Required (ErrorMessage ="Required")]
        public IFormFile Photo { get; set; }

        [NotMapped]
        public IFormFile UpdatePhoto { get; set; }

    }
}
