using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities.Models;
using Repositories;
using Repositories.Contracts;


namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        //private readonly RepositoryContext _context; //prop tanimi
        private readonly IRepositoryManager _manager;

        public ProductController(IRepositoryManager manager)
        {
            _manager = manager;
        }


        public IActionResult Index()
        {
            var model = _manager.Product.GetAllProducts(false);
            return View(model);
        }

        public IActionResult Get(int id)
        {
            //Product product = _context.Products.First(p => p.ProductId.Equals(id));
            throw new NotImplementedException();
            //return View(product);
        }
    }
}