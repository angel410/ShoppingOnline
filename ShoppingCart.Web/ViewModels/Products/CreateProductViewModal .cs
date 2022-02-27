using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingCart.Web.ViewModels.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Web.ViewModels.Products
{
    public class CreateProductViewModal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public IFormFile Image { get; set; }
        public string Desc { get; set; }
  

        public List<SelectListItem> ProductTypesNames { get; set; }
    }
}
