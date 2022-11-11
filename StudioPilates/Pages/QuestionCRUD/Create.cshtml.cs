using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudioPilates.Data;
using StudioPilates.Models;
using System.Threading.Tasks;

namespace StudioPilates.Pages.QuestionCRUD
{
    public class CreateModel : PageModel
    {
        private readonly StudioPilatesContext _context;

        [BindProperty]
        public Question Question { get; set; }

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
            var question = new Question();
            if (await TryUpdateModelAsync<Question>(question, "Question", obj => obj.Text))
            {
                _context.Questions.Add(question);
                await _context.SaveChangesAsync();
                return RedirectToPage("./List");
            }
            return Page();
        }
    }
}
