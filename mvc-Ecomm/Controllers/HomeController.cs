﻿using System.Web.Mvc;

namespace mvc_ecomm.Controllers
{
    public class HomeController : Controller
    {
        // TODO make those instead of making header inside the same website
        //ViewBag.Header = "all";
        //ViewBag.Header = "top";
        //ViewBag.Header = "none";

        // GET: Home
        // GET: Home/Index
        public ActionResult Index()
        {
            ViewBag.Title = "Home | E-Shopper";
            return View();
        }

        // GET: Home/Cart
        public ActionResult Cart()
        { ViewBag.Title = "Cart | E-Shopper"; return View(); }

        // GET: Home/Checkout
        public ActionResult Checkout()
        { ViewBag.Title = "Checkout | E-Shopper"; return View(); }

        // GET: Home/Login
        public ActionResult Login()
        { ViewBag.Title = "Login | E-Shopper"; return View(); }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            //if (username == password) return Redirect("/Accounts/");
            //else 
            return View();
        }

        [HttpPost]
        public ActionResult Signup(string name, string username, string password)
        {
            // TODO create account.
            ViewBag.Title = "Login | E-Shopper"; return View("Login");
        }

        // GET: Home/PageNotFound
        public ActionResult PageNotFound()
        { ViewBag.Title = "PageNotFound | E-Shopper"; return View(); }

        // GET: Home/ProductDetails
        public ActionResult ProductDetails()
        { ViewBag.Title = "ProductDetails | E-Shopper"; return View(); }

        // GET: Home/Shop
        public ActionResult Shop()
        { ViewBag.Title = "Shop | E-Shopper"; return View(); }
    }
}