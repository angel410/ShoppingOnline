using ShoppingCart_.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Services.Interfaces
{
    /// <summary>
    /// Interface for Products  modal
    /// </summary>
    public interface IProducts
    {
        IEnumerable<Products> GetAll();
        Products GetById(int id);
        void InsertProducts(Products Product);
        void EditProducts(Products Product);
        void DeleteProducts(Products Product);
        void Save();
    }
}
