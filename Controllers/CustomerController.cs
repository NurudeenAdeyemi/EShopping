using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EShopping.Models;
using EShopping.Repository;
using EShopping.Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace EShopping.Controllers
{
    public class CustomerController : Controller
    {
       
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            return View(_customerService.GetAll());
        }

        public  IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = _customerService.FindById(id.Value);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customerService.Create(customer);
                
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = _customerService.FindById(id.Value);
            if ( customer== null)
            {
                return NotFound();
            }
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _customerService.Update(customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

     
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = _customerService.FindById(id.Value);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            
            _customerService.Delete(id);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult ShoppingCart()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {

            HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(Customer customer)
        {

            var cust = _customerService.Find(customer);
            if (cust == null)
            {
                ViewBag.Message = "Invalid Username/Password";
                return View();
            }
            else
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, customer.Email),
                    new Claim(ClaimTypes.Email, customer.Email)
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authenticationProperties = new AuthenticationProperties();
                var principal = new ClaimsPrincipal(claimsIdentity);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);
                return RedirectToAction("Index", "Home");
            }

        }
    }

}
