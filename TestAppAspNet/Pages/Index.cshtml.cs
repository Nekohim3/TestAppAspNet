using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace TestAppAspNet.Pages
{
    public class IndexModel : PageModel
    {
        public           List<Order>   Orders { get; set; }
        private readonly TestDbContext _context;

        public IndexModel(TestDbContext db)
        {
            _context = db;
        }
        
        public void OnGet()
        {
            Orders = _context.Orders.AsNoTracking().ToList();
        }
    }
}