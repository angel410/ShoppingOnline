using Microsoft.EntityFrameworkCore;
using ShoppingCart.Services.Data;
using ShoppingCart.Services.Interfaces;
using ShoppingCart_.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Services.Repo
{ 
    /// <summary>
  /// repository for Product Interface
  /// </summary>
    public class ProductsRepo : IProducts
    {
        public readonly AppDbContext _appDbContext;

        public ProductsRepo(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        /// <summary>
        /// Delete Product
        /// </summary>
        /// <param name="Product"></param>
        public void DeleteProducts(Products Product)
        {
            _appDbContext.Remove(Product);
        }
        /// <summary>
        /// Edit Product Info
        /// </summary>
        /// <param name="Product"></param>
        public void EditProducts(Products Product)
        {
            _appDbContext.Products.Update(Product);
        }
        /// <summary>
        /// Get All Products
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Products> GetAll()
        {
            return _appDbContext.Products.ToList();
        }
        /// <summary>
        /// Get Product By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Products GetById(int id)
        {
            return _appDbContext.Products.Where(x => x.Id == id).FirstOrDefault();
        }
        /// <summary>
        /// Insert New Product
        /// </summary>
        /// <param name="Product"></param>
        public void InsertProducts(Products Product)
        {
            
            _appDbContext.Products.Add(Product);
        }

        /// <summary>
        /// Save Changes To Database
        /// </summary>
        public void Save()
        {
            _appDbContext.SaveChanges();
        }
    }
}
