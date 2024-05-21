using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EcomWebRazor.Data;
using EcomWebRazor.Models;


namespace EcomWebRazor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Category> CategoryList  { get; set; } // ??

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
