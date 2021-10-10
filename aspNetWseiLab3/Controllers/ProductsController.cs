using aspNetWseiLab3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspNetWseiLab3.Controllers
{
    public class ProductsController : Controller
    {

        public IActionResult Index()
        {


            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ProductModel product)
        {
            var viewModel = new ProductStatsViewModel
            {
                NameLength = product.Name.Length,
                DescriptionLength = product.Description.Length,
                NameValue = product.Name,
                DescriptionValue = product.Description,
            };
            return View(viewModel);
        }


    }
}
