﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EShopping.Models;
using EShopping.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EShopping.Controllers
{
    [Authorize]
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ICategoryService _categoryService;

        public ItemController(IItemService itemService, IWebHostEnvironment webHostEnvironmrnt, ICategoryService categoryService)
        {
            _itemService = itemService;
            _webHostEnvironment = webHostEnvironmrnt;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View(_itemService.GetAll());
        }

        [AllowAnonymous]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = _itemService.FindById(id.Value);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<Category> categories = _categoryService.GetAll();
            List<SelectListItem> listAItems = new List<SelectListItem>();
            foreach (Category category in categories)
            {
                SelectListItem item = new SelectListItem(category.CategoryName, category.ID.ToString());
                listAItems.Add(item);
            }

            ViewBag.Categories = listAItems;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item item, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if(file != null)
                {
                    string imageDirectory = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                    Directory.CreateDirectory(imageDirectory);
                    string contentType = file.ContentType.Split('/')[1];
                    string fileName = $"{Guid.NewGuid()}.{contentType}";
                    string fullPath = Path.Combine(imageDirectory, fileName);
                    using (var fileStream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    item.ItemPictureUrl = fileName;
                }
                _itemService.Create(item);
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = _itemService.FindById(id.Value);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Item item)
        {
            if (id != item.ItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _itemService.Update(item);
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = _itemService.FindById(id.Value);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _itemService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
