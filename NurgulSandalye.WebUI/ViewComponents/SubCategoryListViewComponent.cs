using Microsoft.AspNetCore.Mvc;
using NurgulSandalye.Business.Abstract;
using NurgulSandalye.DataAccess.Abstract;
using NurgulSandalye.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NurgulSandalye.WebUI.ViewComponents
{
    public class SubCategoryListViewComponent :ViewComponent
    {
        private readonly ISubCategoryService _service;

        public SubCategoryListViewComponent(ISubCategoryService service)
        {
            _service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var subCategories = await _service.ListAllAsync();
            return View(subCategories);
        }
    }
}
