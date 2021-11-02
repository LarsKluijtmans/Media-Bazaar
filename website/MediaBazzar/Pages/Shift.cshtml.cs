using ClassLibrary1;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazzar.Pages
{
    public class ShiftModel : PageModel
    {

        [BindProperty]
        public Shift shift { get; set; }

        public void OnGet()
        { }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                string message = shift.GetInf();
                ViewData["message"] = message;
            }
            return Page();
        }
        
    }
}
