using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MedicalClinic.DataBase.Models;

namespace MedicalClinic.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly DataBase.Context _context;

        public DeleteModel(DataBase.Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Patient Patient { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patients.FirstOrDefaultAsync(m => m.Id == id);

            if (patient == null)
            {
                return NotFound();
            }
            else
            {
                Patient = patient;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patients.FindAsync(id);
            if (patient != null)
            {
                Patient = patient;
                _context.Patients.Remove(Patient);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
