using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers;

public class HomeController : Controller
{


    public IActionResult Index()
    {
        string message = "Merhaba Models-Views-Controllers";
        return View("Index", message);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult GetProduct()
    {
        var product = new Product();
        product.Id = 1;
        product.productName = "Computer";
        product.price = 15000;

        return View("GetProduct", product);
    }

    public IActionResult GetProducts()
    {
        var productList = new List<Product>()
        {
            new Product(1,"Computer",15000),
            new Product(2, "iPhone", 42500)
        };
        return View(productList);
    }
}

