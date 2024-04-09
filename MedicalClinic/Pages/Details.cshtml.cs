using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MedicalClinic.DataBase;
using MedicalClinic.DataBase.Models;

namespace MedicalClinic.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Context _context;

        public DetailsModel(Context context)
        {
            _context = context;
        }

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
    }
}
