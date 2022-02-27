using ShoppingCart_.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Services.Interfaces
{
    /// <summary>
    /// Interface for Users modal
    /// </summary>
    public interface IUsers
    {
        IEnumerable<Users> GetAll();
        Users GetById(int id);
        void InsertUser(Users user);
        void EditUser(Users user);
        void DeleteUser(Users user);
        void Save();
    }
}
