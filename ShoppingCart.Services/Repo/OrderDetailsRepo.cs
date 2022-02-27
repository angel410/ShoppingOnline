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
    /// repository for Order Details Interface
    /// </summary>
    public class OrderDetailsRepo : IOrdersDetails
    {
        public readonly AppDbContext _appDbContext;

        public OrderDetailsRepo(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        /// <summary>
        /// Delete Items From Order
        /// </summary>
        /// <param name="orderDetail"></param>
        public void DeleteOrderDetail(OrderDetails orderDetail)
        {
            _appDbContext.Remove(orderDetail);
        }
        /// <summary>
        /// Edit The Order Details
        /// </summary>
        /// <param name="orderDetail"></param>
        public void EditOrderDetail(OrderDetails orderDetail)
        {
            _appDbContext.OrderDetails.Update(orderDetail);
        }
        /// <summary>
        /// Get All Order Details
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OrderDetails> GetAll()
        {
            return _appDbContext.OrderDetails.Include(y => y.Product).ToList();
        }
        /// <summary>
        /// Get Order Detail By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderDetails GetById(int id)
        {
            return _appDbContext.OrderDetails.Include(y => y.Product).Where(x => x.OrderDetailsId == id).FirstOrDefault();
        }
        /// <summary>
        /// Insert New Items Into Order
        /// </summary>
        /// <param name="orderDetail"></param>
        public void InsertOrderDetail(OrderDetails orderDetail)
        {
            _appDbContext.OrderDetails.Add(orderDetail);
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
