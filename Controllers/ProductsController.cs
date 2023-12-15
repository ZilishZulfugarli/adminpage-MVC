using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using admin_panel.Data;
using admin_panel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace admin_panel.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ProductsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var products = _dbContext.Products.Include(x => x.Category).ToList();
            var model = new ProductsVM
            {
                Products = products
            };
            return View(model);
        }
    }
}

