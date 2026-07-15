using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppStarter.DTO;

namespace WebAppStarter.Pages.Students
{
    public class ViewStudentsModel : PageModel
    {
        public List<StudentReadOnlyDTO> StudentsReadOnlyDTOs { get; set; } = [];
        public IActionResult OnGet()
        {
            string? lastname = Request.Query["lastname"];

            var allStudents = GetAllStudents();

            StudentsReadOnlyDTOs = string.IsNullOrEmpty(lastname)
                ? allStudents
                : [.. allStudents.Where(s => s.Lastname == lastname)];

            return Page();
        }

        private List<StudentReadOnlyDTO> GetAllStudents()
        {
            return [
                new StudentReadOnlyDTO(1, "Γεώργιος", "Αλεξανδρής"),
                new StudentReadOnlyDTO(2, "Γεωργία", "Αλεξανδρή"),
                new StudentReadOnlyDTO(3, "Αθηνά", "Γεωργίου"),
            ];
        }
    }
}
