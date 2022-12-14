using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudioPilates.Data;
using StudioPilates.Models;
using System.Threading.Tasks;

namespace StudioPilates.Pages.PlanCRUD
{
    [Authorize(Policy = "isAdmin")]
    public class CreateModel : PageModel
    {
        private readonly StudioPilatesContext _context;

        [BindProperty]
        public Plan Plan { get; set; }

        public CreateModel(StudioPilatesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var plan = new Plan();
            if (await TryUpdateModelAsync<Plan>(plan, "Plan", obj => obj.Name, obj => obj.Price,
                obj => obj.Payment_recurrence, obj => obj.Contract_recurrence))
            {
                _context.Plans.Add(plan);
                await _context.SaveChangesAsync();
                return RedirectToPage("./List");
            }
            return Page();
        }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    _context.Plans.Add(Plan);
        //    await _context.SaveChangesAsync();

        //    return RedirectToPage("./List");
        //}
    }
}
