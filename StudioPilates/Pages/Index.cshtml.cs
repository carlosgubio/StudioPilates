using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudioPilates.Data;
using StudioPilates.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudioPilates.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly StudioPilatesContext _context;

        public IList<Customer> Customers;

        public IndexModel(ILogger<IndexModel> logger, StudioPilatesContext context)
        {
            _logger = logger;
            _context = context;
        }

        //public async Task OnGetAsync()
        //{
        //    Customers = await _context.Customer.ToListAsync<Customer>();
        //}
    }
}
