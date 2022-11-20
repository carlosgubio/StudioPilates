using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Data;
using StudioPilates.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Question
{
    public class ListModel : PageModel
    {
        private readonly StudioPilatesContext _context;

        public ListModel(StudioPilatesContext context)
        {
            _context = context;
        }

        public IList<Models.Question> Question { get; set; }

        public async Task OnGetAsync()
        {
            Question = await _context.Questions.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Questions.FindAsync(id);

            if (question != null)
            {
                _context.Questions.Remove(question);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./List");
        }
    }
}
