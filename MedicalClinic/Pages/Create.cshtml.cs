using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MedicalClinic.DataBase;
using MedicalClinic.DataBase.Models;

namespace MedicalClinic.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Context _context;

        public CreateModel(Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Patient Patient { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Patients.Add(Patient);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
