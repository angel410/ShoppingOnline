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
    /// repository for Cart Items Interface
    /// </summary>
    public class CartItemssRepo : ICartItems
    {
        public readonly AppDbContext _appDbContext;

        public CartItemssRepo(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        /// <summary>
        /// Delete Items From Cart
        /// </summary>
        /// <param name="CarttIems"></param>
        public void DeleteCarttIems(CarttIems CarttIems)
        {
            _appDbContext.Remove(CarttIems);
        }
        /// <summary>
        /// Edit The Cart 
        /// </summary>
        /// <param name="CarttIems"></param>
        public void EditCarttIems(CarttIems CarttIems)
        {
            _appDbContext.CarttIems.Update(CarttIems);
        }
        /// <summary>
        /// Get All Items From Cart
        /// </summary>
        /// <returns></returns>
        public List<CarttIems> GetAll()
        {
            return _appDbContext.CarttIems.Include(y=>y.Products).ToList();
        }

        /// <summary>
        /// Get Items From Cart By User
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public List<CarttIems> GetByUserId(int UserId)
        {
            return _appDbContext.CarttIems.Include(y => y.Products).Where(x=>x.UserId== UserId).ToList();
        }
        /// <summary>
        /// Insert Items To Cart
        /// </summary>
        /// <param name="CarttIems"></param>
        public void InsertCarttIems(CarttIems CarttIems)
        {
            _appDbContext.CarttIems.Add(CarttIems);
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
