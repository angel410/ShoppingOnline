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
    /// repository for Users Interface
    /// </summary>
    public class UsersRep : IUsers
    {
        public readonly AppDbContext _appDbContext;

        public UsersRep(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        /// <summary>
        /// Delete User
        /// </summary>
        /// <param name="user"></param>
        public void DeleteUser(Users user)
        {
            _appDbContext.Remove(user);
        }
        /// <summary>
        /// Edit User Info
        /// </summary>
        /// <param name="user"></param>
        public void EditUser(Users user)
        {
            _appDbContext.Users.Update(user);
        }
        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Users> GetAll()
        {
            return _appDbContext.Users.ToList();
        }
        /// <summary>
        /// Get User By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Users GetById(int id)
        {
            return _appDbContext.Users.Where(x => x.Id == id).FirstOrDefault();
        }
        /// <summary>
        /// Insert New User
        /// </summary>
        /// <param name="user"></param>
        public void InsertUser(Users user)
        {
            _appDbContext.Users.Add(user);
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
