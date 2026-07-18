using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppStarter.DTO;
using WebAppStarter.Model;

namespace WebAppStarter.Pages.Teachers
{
    public class InsertModel : PageModel
    {
        [BindProperty]
        public InsertTeacherDTO? InsertTeacherDTO { get; set; }
        public TeacherReadOnlyDTO? TeacherReadOnlyDTO { get; set; }
        public SelectList? Cities { get; set; }

        public void OnGet()
        {
            InsertTeacherDTO = new InsertTeacherDTO();
            LoadCities();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                LoadCities();
                return Page();
            }

            // Service
            TeacherReadOnlyDTO = new TeacherReadOnlyDTO(1, InsertTeacherDTO?.Firstname,
                InsertTeacherDTO?.Lastname);

            TempData["TeacherName"] =
                $"{TeacherReadOnlyDTO.Firstname}, {TeacherReadOnlyDTO.Lastname}";

            return RedirectToPage("/Teachers/Success");
        }

        private void LoadCities()
        {
            Cities = new SelectList(new List<City>()
            {
                new City { Id = 1, Name = "Αθήνα" },
                new City { Id = 2, Name = "Πάτρα" },
                new City { Id = 3, Name = "Ηράκλειο" },
                new City { Id = 4, Name = "Δράμα" },
            }.OrderBy(c => c.Name), nameof(City.Id), nameof(City.Name));
        }
    }
}