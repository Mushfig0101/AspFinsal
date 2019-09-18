using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Indecor.Models
{
    public class AltSlider
    {
  
        public int Id { get; set; }
        [Required(ErrorMessage ="Required"), StringLength(255, ErrorMessage ="Length can't be morethan 255")]
        public string Image { get; set; }

    }
}
