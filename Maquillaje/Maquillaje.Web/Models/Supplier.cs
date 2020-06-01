using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Maquillaje.Web.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [Display(Name = "Codigo")]
        [MaxLength(100)]
        public string SupplierCode { get; set; }
        [Display(Name = "Proveedor")]
        [MaxLength(100)]
        public string SupplierName { get; set; }
        [Display(Name = "Correo Electrónico")]
        [MaxLength(100)]
        public string Email { get; set; }
        [Display(Name = "Teléfono")]
        public int Phone { get; set; }

    }
}