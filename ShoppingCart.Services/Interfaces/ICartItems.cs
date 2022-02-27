using ShoppingCart_.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Services.Interfaces
{
    /// <summary>
    /// Interface for Cart Items modal
    /// </summary>
    public interface ICartItems
    {
        List<CarttIems> GetAll();
        List<CarttIems> GetByUserId(int UserId);
        void InsertCarttIems(CarttIems CarttIems);
        void EditCarttIems(CarttIems CarttIems);
        void DeleteCarttIems(CarttIems CarttIems);
        void Save();
    }
}
