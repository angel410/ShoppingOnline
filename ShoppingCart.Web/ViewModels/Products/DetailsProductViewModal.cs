using ShoppingCart.Web.ViewModels.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Web.ViewModels.Products
{
    public class DetailsProductViewModal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Desc { get; set; }
  
        public IList<ProductTypesViewModal> ProductTypesNames { get; set; }

    }
}
