using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NurgulSandalye.WebUI.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OrderAdress()
        {
            return View();
        }
        public IActionResult OrderPayment()
        {
            return View();
        }
        public IActionResult OrderConfirmation()
        {
            return View();
        }
    }
}
