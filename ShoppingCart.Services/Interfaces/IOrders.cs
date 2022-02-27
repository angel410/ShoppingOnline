using ShoppingCart_.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Services.Interfaces
{
    /// <summary>
    /// Interface for Order MOdal
    /// </summary>
    public interface IOrders
    {
        IEnumerable<Order> GetAll();
        Order GetById(int id);
        void InsertOrder(Order order);
        void EditOrder(Order order);
        void DeleteOrder(Order order);
        void Save();
    }
}
