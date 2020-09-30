using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShopping.Models;
using EShopping.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EShopping.Controllers
{
    
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View(_orderService.GetAll());
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = _orderService.FindById(id.Value);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                _orderService.Create(order);
               
            }
            return RedirectToAction("Confirmation", "Order");
            
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = _orderService.FindById(id.Value);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _orderService.Update(order);
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = _orderService.FindById(id.Value);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _orderService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
