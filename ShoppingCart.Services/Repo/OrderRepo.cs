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
    /// repository for Order Interface
    /// </summary>
    public class OrderRepo : IOrders
    {
        public readonly AppDbContext _appDbContext;

        public OrderRepo(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        /// <summary>
        /// Delete Order
        /// </summary>
        /// <param name="order"></param>
        public void DeleteOrder(Order order)
        {
            _appDbContext.Remove(order);
        }
        /// <summary>
        /// Edit Order
        /// </summary>
        /// <param name="order"></param>
        public void EditOrder(Order order)
        {
            _appDbContext.Order.Update(order);
        }
        /// <summary>
        /// Get All Orders
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Order> GetAll()
        {
            return _appDbContext.Order.Include(y => y.OrderDetails).ToList();
        }
        /// <summary>
        /// Get Order By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Order GetById(int id)
        {
            return _appDbContext.Order.Include(y => y.OrderDetails).Where(x => x.Id == id).FirstOrDefault();
        }
        /// <summary>
        /// Inset New Order
        /// </summary>
        /// <param name="order"></param>
        public void InsertOrder(Order order)
        {
            _appDbContext.Order.Add(order);
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
