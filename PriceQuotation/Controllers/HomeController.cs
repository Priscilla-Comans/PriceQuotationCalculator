using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PriceQuotation.Models;

namespace PriceQuotation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
          
            ViewBag.FV = 0;
            ViewBag.Result = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(PriceQuotationModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculateDiscountAmount();
                ViewBag.Result = model.CalculateTotal();
            }
            else
            {
                ViewBag.FV = 0;
                ViewBag.Result = 0;
            }
            return View(model);
        }
    }
}
