using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppStarter.DTO;

namespace WebAppStarter.Pages.Teachers
{
    public class ViewTeachersModel : PageModel
    {
        public List<TeacherReadOnlyDTO> TeachersReadOnlyDTOs { get; set; } = [];
        public IActionResult OnGet()
        {
            string? lastname = Request.Query["lastname"];

            var allTeachers = GetAllTeachers();

            TeachersReadOnlyDTOs = string.IsNullOrEmpty(lastname)
                ? allTeachers
                : [.. allTeachers.Where(s => s.Lastname == lastname)];

            return Page();
        }

        private List<TeacherReadOnlyDTO> GetAllTeachers()
        {
            return [
                new TeacherReadOnlyDTO(1, "Νικολέτα", "Ανδριανού"),
                new TeacherReadOnlyDTO(2, "Νατάσσα", "Αλεξανδρή"),
                new TeacherReadOnlyDTO(3, "Αλέξανδρος", "Πανούκης"),
            ];
        }
    }
}
