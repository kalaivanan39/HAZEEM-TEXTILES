using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HazeemTextiles.Data;
using HazeemTextiles.Model;

namespace HazeemTextiles.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly HazeemTextiles.Data.HazeemTextilesContext _context;

        public IndexModel(HazeemTextiles.Data.HazeemTextilesContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
