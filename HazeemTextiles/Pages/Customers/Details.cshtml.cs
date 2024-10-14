﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly HazeemTextiles.Data.HazeemTextilesContext _context;

        public DetailsModel(HazeemTextiles.Data.HazeemTextilesContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FirstOrDefaultAsync(m => m.CustomerID == id);
            if (customer == null)
            {
                return NotFound();
            }
            else
            {
                Customer = customer;
            }
            return Page();
        }
    }
}
