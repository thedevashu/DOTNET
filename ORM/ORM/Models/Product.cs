using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ORM.Models
{
    [Table("product")]
    public class Product
    {
        
        public int Id { get; set; }
        public string PrductName { get; set; }
        public string Dsc { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}