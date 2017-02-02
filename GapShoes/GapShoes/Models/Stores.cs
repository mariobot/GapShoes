using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GapShoes.Models
{
    public class Stores
    {
        [Key]
        public int StoreID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string  address { get; set; }
    }
}