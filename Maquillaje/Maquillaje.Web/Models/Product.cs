using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Maquillaje.Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Codigo")]
    

        public string ProductCode { get; set; }
        [Display(Name = "Nombre")]
        [MaxLength(50)]

        public string ProductName { get; set; }
        [Display(Name = "Descripcion")]
        [MaxLength(300)]

        public string Description { get; set; }
        [Display(Name = "Precio")]
        [MaxLength(100)]

        public string Price { get; set; }
        public int SupplirId { get; set; }
        [ForeignKey("SupplirId")]

        public Supplier Supplier { get; set; }


    }
}