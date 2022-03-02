using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:15,MinimumLength =3,ErrorMessage ="Enter Name Properly")]
        public string PrductName { get; set; }
        [Required]
        [StringLength(maximumLength: 15, MinimumLength = 3, ErrorMessage = "Enter Desc Properly")]
        public string Dsc { get; set; }
        [Required]
        [Range(maximum:50,minimum:5)]
        public int Quantity { get; set; }
        [Required]
        public int Price { get; set; }


    }
}
