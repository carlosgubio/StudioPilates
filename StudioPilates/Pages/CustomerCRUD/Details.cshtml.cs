﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Models;
using System.Threading.Tasks;

namespace StudioPilates.Pages.CustomerCRUD
{
    public class DetailsModel : PageModel
    {
        private readonly StudioPilates.Data.StudioPilatesContext _context;

        public DetailsModel(StudioPilates.Data.StudioPilatesContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customers.FirstOrDefaultAsync(m => m.Id_customer == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);

            if (Customer != null)
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }
            return Page(); 
        }
    }
}