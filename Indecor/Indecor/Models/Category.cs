using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Indecor.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Required"), StringLength(200, ErrorMessage = "Length can't be more than 200")]
        public string CategoryName { get; set; }
        public string Active { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
