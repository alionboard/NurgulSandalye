using Microsoft.AspNetCore.Mvc.Rendering;
using NurgulSandalye.Business.Abstract;
using NurgulSandalye.WebUI.Interfaces;
using NurgulSandalye.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NurgulSandalye.WebUI.Services
{
    public class ShopIndexViewModelManager : IShopIndexViewModelService
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly ISubCategoryService _subCategoryService;
        private readonly IMaterialService _materialService;

        public ShopIndexViewModelManager(IProductService productService,ICategoryService categoryService,ISubCategoryService subCategoryService,IMaterialService materialService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _subCategoryService = subCategoryService;
            _materialService = materialService;
        }
        public async Task<ShopIndexViewModel> GetShopIndexViewModel(int? categoryId, int? subCategoryId, int? materialId)
        {
            var products = await _productService.ListAllProductAsync();

            return new ShopIndexViewModel()
            {
                Products = products.Select(x => new ProductViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    PictureUris = x.PictureUris.ToList()
                }).ToList()
            };
        }

        public Task<List<SelectListItem>> GetCategoryListItem()
        {
            throw new NotImplementedException();
        }

        public Task<List<SelectListItem>> GetMaterialListItem()
        {
            throw new NotImplementedException();
        }


        public Task<List<SelectListItem>> GetSubCategoryListItem()
        {
            throw new NotImplementedException();
        }
    }
}
