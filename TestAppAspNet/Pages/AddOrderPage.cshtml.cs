using System;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestAppAspNet
{
    public class AddOrderPage : PageModel
    {
        [BindProperty]
        public Order Order { get; set; }
        private readonly TestDbContext _context;
        
        public AddOrderPage(TestDbContext db)
        {
            _context = db;
        }
        public void OnGet()
        {
            Order = new Order() {Date = DateTime.Now};
        }
        
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
                return Page();
            else
            {
                _context.Orders.Add(Order);
                _context.SaveChanges();
                return RedirectToPage("Index");
            }
        }
    }
}