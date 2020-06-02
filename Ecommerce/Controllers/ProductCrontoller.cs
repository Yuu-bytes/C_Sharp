using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    public class ProductController : Controller
    {
    List<Product> lsProduct = new List<Product>();

    public  ProductController(){
        lsProduct.Add(new Product{
            Id = 1,
            Name = "Televisor"
        });
        lsProduct.Add(new Product{
            Id = 2,
            Name = "Smarphone"
        });
        lsProduct.Add(new Product{
            Id = 3,
            Name = "Notebook"
        });
    }
        public IActionResult Index()
        {
            return View(lsProduct);
        }
    }
}
