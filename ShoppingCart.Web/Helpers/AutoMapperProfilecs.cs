using AutoMapper;
//using ShoppingCart.Web.ViewModels.Products;
//using ShoppingCart.Web.ViewModels.ProductTypes;
using ShoppingCart_.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Web.Helpers
{
    public class AutomappperProfile :  Profile
    {
        public AutomappperProfile ()
        {
            //CreateMap<ProductTypes, ProductTypesViewModal>().ReverseMap();
            //CreateMap<ProductTypes, EditProductTypesViewModal>().ReverseMap();
            //CreateMap<ProductTypes, CreateProductTypesViewModal>().ReverseMap();
            //CreateMap<Products, ProductViewModal>().ReverseMap();
            //CreateMap<Products, DetailsProductViewModal>().ForMember(dest => dest.ProductTypesNames, opt => opt.MapFrom(src => src.ProductTypes.ProductType.ToList()));
            //CreateMap<Products, CreateProductViewModal>().ReverseMap();
            //CreateMap<PostProductViewModal, Products>().ReverseMap();
        }
    }
}
