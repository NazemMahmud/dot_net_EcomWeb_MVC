using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EcomWebRazor.Data;
using EcomWebRazor.Models;

namespace EcomWebRazor.Pages.Categories
{
    //[BindProperties] // if there are more property to bind, use this
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Category Category { get; set; } // ??

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult OnPost()
        {
            _db.Categories.Add(Category);
            _db.SaveChanges();
            TempData["success"] = "Category Is Created Successfully.";
            return RedirectToPage("Index", "Categories");
        }
    }
}