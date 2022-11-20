using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Data;
using StudioPilates.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Question
{
    public class EditModel : PageModel
    {
        private readonly StudioPilatesContext _context;

        public EditModel(StudioPilatesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Question Question { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            
            Question = await _context.Questions.FirstOrDefaultAsync(m => m.Id_question == id);

            if (Question == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Question).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionExists(Question.Id_question))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./List");
        }

        private bool QuestionExists(int id)
        {
            return _context.Questions.Any(e => e.Id_question == id);
        }
    }
}
