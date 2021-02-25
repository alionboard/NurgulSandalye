using Microsoft.AspNetCore.Mvc;
using NurgulSandalye.WebUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NurgulSandalye.WebUI.Controllers
{
    public class ShopController : Controller
    {
        private readonly IShopIndexViewModelService _shopIndexViewModelService;

        public ShopController(IShopIndexViewModelService shopIndexViewModelService)
        {
            _shopIndexViewModelService = shopIndexViewModelService;
        }
        public async Task<IActionResult> Index(int? categoryId, int? subCategoryId, int? materialId)
        {
            return View(await _shopIndexViewModelService.GetShopIndexViewModel(categoryId,subCategoryId,materialId));
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
