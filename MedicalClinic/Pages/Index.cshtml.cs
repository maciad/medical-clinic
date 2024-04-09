using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MedicalClinic.DataBase;
using MedicalClinic.DataBase.Models;
using Microsoft.AspNetCore.Mvc;
using MedicalClinic.Core;

namespace MedicalClinic.Pages;

    public class IndexModel : PageModel
    {
        private readonly Context _context;

        public IndexModel(Context context)
        {
            _context = context;
        }

        public PaginatedList<Patient> Patient { get;set; } = default!;
        public string SortType { get; set; } = default!;

        public async Task OnGetAsync(string? sortOrder, int? pageIndex)
        {
            IQueryable<Patient> patientsIQ = from s in _context.Patients select s;

            switch (sortOrder)
            {
                case "Name":
                    patientsIQ = patientsIQ.OrderBy(s => s.firstName);
                    SortType = "Name";
                    break;
                case "name_desc":
                    patientsIQ = patientsIQ.OrderByDescending(s => s.firstName);
                    SortType = "name_desc";
                    break;
                case "LastName":
                    patientsIQ = patientsIQ.OrderBy(s => s.lastName);
                    SortType = "LastName";
                    break;
                case "last_name_desc":
                    patientsIQ = patientsIQ.OrderByDescending(s => s.lastName);
                    SortType = "last_name_desc";
                    break;
                case "Pesel":
                    patientsIQ = patientsIQ.OrderBy(s => s.pesel);
                    SortType = "Pesel";
                    break;
                case "pesel_desc":
                    patientsIQ = patientsIQ.OrderByDescending(s => s.pesel);
                    SortType = "pesel_desc";
                    break;
                case "Email":
                    patientsIQ = patientsIQ.OrderBy(s => s.email);
                    SortType = "Email";
                    break;
                case "email_desc":
                    patientsIQ = patientsIQ.OrderByDescending(s => s.email);
                    SortType = "email_desc";
                    break;
                case "City":
                    patientsIQ = patientsIQ.OrderBy(s => s.city);
                    SortType = "City";
                    break;
                case "city_desc":
                    patientsIQ = patientsIQ.OrderByDescending(s => s.city);
                    SortType = "city_desc";
                    break;
                case "Street":
                    patientsIQ = patientsIQ.OrderBy(s => s.street);
                    SortType = "Street";
                    break;
                case "street_desc":
                    patientsIQ = patientsIQ.OrderByDescending(s => s.street);
                    SortType = "street_desc";
                    break;
                case "ZipCode":
                    patientsIQ = patientsIQ.OrderBy(s => s.zipCode);
                    SortType = "ZipCode";
                    break;
                case "zip_code_desc":
                    patientsIQ = patientsIQ.OrderByDescending(s => s.zipCode);
                    SortType = "zip_code_desc";
                    break;
            }

            int pageSize = 15;
            Patient = await PaginatedList<Patient>.CreateAsync(
                patientsIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }

    public IActionResult OnPostAddRandom()
        {
        SampleDataGenerator.addRandom();

        return RedirectToPage();
        }

    }


