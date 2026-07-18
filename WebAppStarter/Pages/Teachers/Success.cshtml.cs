using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppStarter.Pages.Teachers
{
    public class SuccessModel : PageModel
    {
        public string? TeacherName { get; set; }

        public void OnGet()
        {
            TeacherName = TempData["TeacherName"] as string;
        }
    }
}
