using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingCart.Services.Interfaces;

using ShoppingCart_.DAL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Web.Controllers
{
    public class ProductsController : Controller
    {
        
        private readonly IProducts _Products;
        private IWebHostEnvironment _he;
        public ProductsController(IProducts Products, IWebHostEnvironment he)
        {
            _Products = Products;
            _he = he;
        }
        /// <summary>
        /// List Of All Product For Admin
        /// </summary>
        /// <returns></returns>
        [HttpGet]     
        public IActionResult Index()
        {
            var Products = _Products.GetAll();
            return View(Products);
        }
      /// <summary>
      /// Delete Product
      /// </summary>
      /// <param name="id">Product Id</param>
      /// <returns></returns>
        public IActionResult Delete(int id)
        {
            var ProductDeleted = _Products.GetAll().Where(y => y.Id == id).FirstOrDefault();
            _Products.DeleteProducts(ProductDeleted);
            _Products.Save();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Edit Product Info
        /// </summary>
        /// <param name="id">Product Id</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Edit(int id)
        {
          
            return View(_Products.GetById(id));
        }
        /// <summary>
        /// Post Edit Product Info
        /// </summary>
        /// <param name="vm">Products </param>
        /// <param name="image">image</param>
        /// <returns></returns>
        [HttpPost]    
        public IActionResult Edit(Products vm, IFormFile image)
        {
            Products Products = _Products.GetAll().Where(u => u.Id == vm.Id).FirstOrDefault();
            Products.Name = vm.Name;
            Products.Price = vm.Price;
            Products.Quantity = vm.Quantity;
            Products.Desc = vm.Desc;
            if (image != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    image.CopyToAsync(new FileStream(name, FileMode.Create));
                    vm.Image = "Images/" + image.FileName;
                }

                if (image == null)
                {
                    vm.Image = "Images/noimage.PNG";
                }
                _Products.EditProducts(Products);
                _Products.Save();
                return RedirectToAction("Index");
            
        }
        /// <summary>
        /// Create New Product
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }
        /// <summary>
        /// Create New Product
        /// </summary>
        /// <param name="vm">Products</param>
        /// <param name="image">image</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Products vm, IFormFile image)
        {
            if (image != null)
            {
                var name = Path.Combine(_he.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                 image.CopyToAsync(new FileStream(name, FileMode.Create));
                vm.Image = "Images/" + image.FileName;
            }

            if (image == null)
            {
                vm.Image = "Images/noimage.PNG";
            }
            _Products.InsertProducts(vm);
            _Products.Save();
            return RedirectToAction("Index");
        }


    }
}
