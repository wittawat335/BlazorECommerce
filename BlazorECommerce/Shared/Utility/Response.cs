using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorECommerce.Shared.Utility
{
    public class Response<T>
    {
        public bool Status { get; set; }
        public T? Value { get; set; }
        public string? Message { get; set; }
        public bool Success { get; set; } = true;
        public string? CssClass { get; set; } = "success";
    }
}
