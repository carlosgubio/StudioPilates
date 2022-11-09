using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Customer_planCRUD
{
    public class IndexModel : PageModel
    {
        private readonly StudioPilates.Data.ApplicationDbContext _context;

        public IndexModel(StudioPilates.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Customer_plan> Customer_plan { get; set; }

        public async Task OnGetAsync()
        {
            Customer_plan = await _context.Customer_plans.ToListAsync();
        }
    }
}
