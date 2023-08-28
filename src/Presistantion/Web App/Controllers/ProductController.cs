using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Magpul.Persistence.DbContexts;
using MagpulShop.Domain.Entitys;
using Microsoft.AspNetCore.Mvc;
using Web_app.Models;
using Web_app.Services;

namespace Web_app.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(ProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _productService.GetAll().Result.AsQueryable();

            var productViewModels = _mapper.ProjectTo<ProuductViewModel>(products);

            return Ok(productViewModels);
        }

        [Route("by-subcategory")]
        [HttpGet]
        public IActionResult GetBySubCategoryActionResult(ProductSubCategoryVeiwModel model)
        {
            var productSubCategory =
                _mapper.Map<ProductSubCategory>(model); 

            var products =
                _productService.GetBySubCategory(productSubCategory)
                    .Result;

            var productViewModels = _mapper.ProjectTo<ProductViewModel>(products);

            return Ok(productViewModels);

        }

        [Route("by-category")]
        [HttpGet]
        public IActionResult GetByCategoryActionResult(ProductCategoryViewModel model)
        {
            var productCategory =
                _mapper.Map<ProductCategory>(model);

            var products =
                _productService.GetByCategory(productCategory)
                    .Result.AsQueryable();

            var productViewModels = _mapper.ProjectTo<ProductViewModel>(products);

            return Ok(productViewModels);

        }
        [Route("by-id-category")]
        public IActionResult GetByIdCategoryActionResult(int id)
        {
            var products = _productService.GetByIdCategory(id).Result.AsQueryable();

            var productsViewModels = _mapper.ProjectTo<ProuductViewModel>(products);

            return Ok(productsViewModels);
        }

        [Route("by-id-subcategory")]
        [HttpGet]
        public IActionResult GetByIdSubCategoryActionResult(int id)
        {
            var products = _productService.GetByIdSubCategory(id).Result.AsQueryable();

            var productsViewModels = _mapper.ProjectTo<ProuductViewModel>(products);

            return Ok(productsViewModels);
        }


        [Route("add")]
        [HttpPost]
        public IActionResult AddProduct(ProductViewModel model)
        {
            var product = _mapper.Map<Product>(model);
#pragma warning disable CS4014
            _productService.AddProduct(product);
#pragma warning restore CS4014

            return Ok();
        }

    }
}
