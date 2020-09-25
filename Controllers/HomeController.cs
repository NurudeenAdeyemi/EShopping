using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EShopping.Models;
using EShopping.Service;

namespace EShopping.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IItemService _itemService;

        public HomeController(IItemService itemService, ILogger<HomeController> logger)
        {
            _logger = logger;
            _itemService = itemService;
        }

        public IActionResult Index()
        {
            var items = _itemService.GetAll();
            return View(items);
        }

        public IActionResult Privacy()
        {
            var items = _itemService.GetAll();
            return View(items);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult AboutUs()
        {
            return View();
        }

        [HttpGet]

        public IActionResult Search(int id, Item item)
        {
            if (item == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var itemName = _itemService.GetAll();
                return View("SearchProduct");
            }
            return View(item);
        }

    }
}
