using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab13_2CoffeeShopProductList.Models;

namespace Lab13_2CoffeeShopProductList.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> prod = DAL.GetAllProducts();
            return View(prod);
        }

        public IActionResult ProductDetails(int id)
        {
            Product prod = DAL.GetProduct(id);
            return View(prod);
        }
    }
}
