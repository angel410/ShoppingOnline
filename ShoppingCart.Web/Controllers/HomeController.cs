using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using ShoppingCart.Services.Interfaces;
using ShoppingCart_.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProducts _Products;
        private readonly ICartItems _CartItems;
        private readonly IOrdersDetails _OrdersDetails;
        private readonly IOrders _Orders;

        // GET: HomeController

        public HomeController(IProducts Products, ICartItems CartItems, IOrdersDetails OrdersDetails, IOrders Orders)
        {
            _Products = Products;
            _CartItems = CartItems;
            _OrdersDetails = OrdersDetails;
            _Orders = Orders;

        }

        /// <summary>
        /// List Of All Orders
        /// </summary>
        /// <returns></returns>
        public ActionResult AllOrders()
        {
            var orders = _Orders.GetAll();
            return View(orders);
        }

        /// <summary>
        /// Home Page And List Of All Products For Users 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var Products = _Products.GetAll();
            return View(Products);
        }
        /// <summary>
        /// List Of All Orders To Specefic User
        /// </summary>
        /// <returns>Orders</returns>
        public IActionResult CustomerOrders()
        {
            var UserId = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
            return View(_Orders.GetAll().Where(y => y.UserId == UserId).ToList());
        }
        /// <summary>
        /// List Of Order Detail For Specefic Order
        /// </summary>
        /// <param name="id">Order Id</param>
        /// <returns></returns>

        public IActionResult CustomerOrderDetails(int id)
        {
            return View(_OrdersDetails.GetAll().Where(y => y.OrderId == id).ToList());
        }
        /// <summary>
        /// Insert New Items To Cart,Update Cart
        /// </summary>
        /// <param name="Id">Product Id</param>
        /// <param name="Quantity">Product Quantity</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddToCart(int Id, int Quantity)
        {
            var UserId = Convert.ToInt32(HttpContext.Session.GetString("UserId"));

            var ProductPrice = _Products.GetById(Id).Price;
            var ItemPrice = Quantity * ProductPrice;
            //Check If Product Still Exsist
            if (_Products.GetById(Id).Quantity >= Quantity)
            {
                //Check If Item Exsist In Cart If Exsist Update The Quantity Of Product
                if (_CartItems.GetAll().Where(u => u.ProductId == Id).Any())
                {
                    CarttIems itemUpdate = _CartItems.GetAll().Where(u => u.ProductId == Id).FirstOrDefault();
                    itemUpdate.Price = _CartItems.GetAll().Where(u => u.ProductId == Id).Select(y => y.Price).FirstOrDefault() + ItemPrice;
                    itemUpdate.Quantity = _CartItems.GetAll().Where(u => u.ProductId == Id).Select(y => y.Quantity).FirstOrDefault() + Quantity;
                    _CartItems.EditCarttIems(itemUpdate);
                    _CartItems.Save();
                }
                else
                {
                    //If Else Add New Product To Cart
                    CarttIems item = new CarttIems();
                    item.Price = ItemPrice;
                    item.Quantity = Quantity;
                    item.ProductId = Id;
                    item.UserId = UserId;
                    _CartItems.InsertCarttIems(item);
                    _CartItems.Save();
                }
                ViewBag.cart = _CartItems.GetAll().Where(y => y.UserId == UserId).ToList();
                return View(ViewBag.cart);
            }
            else
            {
                ViewBag.SoldOut = "Ops Items Is Sold Out";
                return RedirectToAction("Index");
            }
        }

        /// <summary>
        /// Checkout The Cart And Making Order Then Empty The Cart
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Order()
        {
            int i = 0;
            var UserId = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
            var OrderTotalPrice = _CartItems.GetByUserId(UserId).Select(y => y.Price).Sum();
            var Porducts = _CartItems.GetByUserId(UserId).Select(y => y.ProductId).ToList();
            //Make The order
            Order Order = new Order();
            Order.OrderDate = DateTime.Now;
            Order.UserId = UserId;
            Order.OrderTotlPrice = OrderTotalPrice;
            _Orders.InsertOrder(Order);
            //Make The Order Details
            foreach (var item in Porducts)
            {
                //i++;
                OrderDetails OrderDetails = new OrderDetails();
                //OrderDetails.OrderDetailsId = i;
                OrderDetails.Order = Order;
                OrderDetails.PorductId = item;
                OrderDetails.Quantity = _CartItems.GetAll().Where(y => y.ProductId == item && y.UserId == UserId).Select(y => y.Quantity).FirstOrDefault();
                _OrdersDetails.InsertOrderDetail(OrderDetails);


            }
            //Empty The Cart
            foreach (var item in _CartItems.GetByUserId(UserId).ToList())
            {
                _CartItems.DeleteCarttIems(item);
                _CartItems.Save();
            }
            _OrdersDetails.Save();
            return RedirectToAction("CustomerOrders");
        }
        /// <summary>
        /// List The Cart Details
        /// </summary>
        /// <returns></returns>
        public IActionResult CartDetails()
        {
            var UserId = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
            ViewBag.cart = _CartItems.GetAll().Where(y => y.UserId == UserId).ToList();
            return View(ViewBag.cart);
        }
        /// <summary>
        /// Delete Items From Cart
        /// </summary>
        /// <param name="id">Cart Id</param>
        /// <returns></returns>
        public IActionResult DeleteItemFromCart(int id)
        {
            var CartItem = _CartItems.GetAll().Where(y => y.Id == id).FirstOrDefault();
            _CartItems.DeleteCarttIems(CartItem);
            _CartItems.Save();
            return RedirectToAction("Index");
        }


    }
}
