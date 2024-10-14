﻿using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities.Models;
using Repositories;
using Repositories.Contracts;
using Services.Contracts;


namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        //private readonly RepositoryContext _context; //prop tanimi
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var model = _manager.ProductService.GetAllProducts(false);
            return View(model);
        }

        public IActionResult Get([FromRoute(Name = "id")] int id)
        {
            //Product product = _context.Products.First(p => p.ProductId.Equals(id));
            var model = _manager.ProductService.GetOneProduct(id, false);
            return View(model);
        }
    }
}