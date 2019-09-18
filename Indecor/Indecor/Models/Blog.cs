
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Indecor.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Required"), StringLength(300, ErrorMessage = "Length can't be more than 300")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Required"), StringLength(200, ErrorMessage = "Length can't be more than 200")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Day { get; set; }
        [Required(ErrorMessage ="Requiored"), StringLength(255,ErrorMessage = "Length can't be more than 255 ")]
        public string Path { get; set; }
    }
}
