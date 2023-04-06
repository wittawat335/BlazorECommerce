using BlazorECommerce.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorECommerce.Shared.DTO
{
    public class ServiceDTO
    {
        public List<Product>? ProductList { get; set; } = null;
        public Product? SingleProduct { get; set; } = null;
        public bool Success { get; set; } = true;
        public string? CssClass { get; set; } = "success";
        public string? Message { get; set; } = null;
    }
}
