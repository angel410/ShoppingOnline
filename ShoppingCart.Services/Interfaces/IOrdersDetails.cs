using ShoppingCart_.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Services.Interfaces
{
    /// <summary>
    /// Interface for Order Details  modal
    /// </summary>
    public interface IOrdersDetails
    {
        IEnumerable<OrderDetails> GetAll();
        OrderDetails GetById(int id);
        void InsertOrderDetail(OrderDetails orderDetail);
        void EditOrderDetail(OrderDetails orderDetail);
        void DeleteOrderDetail(OrderDetails orderDetail);
        void Save();
    }
}
