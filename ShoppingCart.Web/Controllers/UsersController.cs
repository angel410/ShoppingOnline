using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Services.Interfaces;
using ShoppingCart_.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsers _Users;

        public UsersController(IUsers Users)
        {
            _Users = Users;
        }
        /// <summary>
        /// List Of All Users
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {

            var users = _Users.GetAll();
            return View(users);
        }
        /// <summary>
        /// Create New User
        /// </summary>
        /// <param name="vm">User</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Users vm)
        {
            //var mappedProductTypesInModal = _mapper.Map<ProductTypes>(vm);
            _Users.InsertUser(vm);
            _Users.Save();
            ViewBag.message = "User Created successfully";
            return View("Login");
        }
        /// <summary>
        /// Login Action
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }
        /// <summary>
        /// Login Action
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Login(string UserName, string password)
        {
            if (_Users.GetAll().Select(y=>y.UserName== password).Count()>0 && _Users.GetAll().Select(y => y.Password == password).Count()>0)
            {
                HttpContext.Session.SetString("UserId", _Users.GetAll().Where(t => t.Password == password && t.UserName==UserName).Select(y=>y.Id).FirstOrDefault().ToString());
                HttpContext.Session.SetString("UserRole", _Users.GetAll().Where(t => t.Password == password && t.UserName == UserName).Select(y => y.UserRoleId).FirstOrDefault().ToString());

                return RedirectToAction("Index", "Home");

            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View("Login");
            }
        }
        /// <summary>
        /// Logout Action
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserId");
            return RedirectToAction("Login");
        }

    }
}
