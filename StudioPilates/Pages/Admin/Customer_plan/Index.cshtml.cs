using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Customer_plan
{
    public class IndexModel : PageModel
    {
        private readonly StudioPilates.Data.StudioPilatesContext _context;

        public IndexModel(StudioPilates.Data.StudioPilatesContext context)
        {
            _context = context;
        }

        public IList<Models.Customer_plan> Customer_plan { get; set; }

        public async Task OnGetAsync()
        {
            Customer_plan = await _context.Customer_plans.ToListAsync();
        }
    }
}
