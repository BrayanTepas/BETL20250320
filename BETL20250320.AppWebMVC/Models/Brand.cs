using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BETL20250320.AppWebMVC.Models;

public partial class Brand
{
    public int BrandId { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [Display(Name = "nombre")]
    public string BrandName { get; set; } = null!;
    [Display(Name = "pais")]
    public string? Country { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}