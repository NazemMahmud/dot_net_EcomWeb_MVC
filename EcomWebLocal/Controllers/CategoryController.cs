﻿using EcomWebLocal.Data;
using EcomWebLocal.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcomWebLocal.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Category> categoryList = _db.Categories.ToList();
            return View(categoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (category.Name == category.DisplayOrder.ToString()) 
            {
                ModelState.AddModelError("name", "DisplayOrder can't exactly match with name");    
            }

            if (ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index", "Category");
            }

            return View();
        }
    }
}