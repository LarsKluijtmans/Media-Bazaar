using ClassLibrary1;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazzar.Pages
{
    public class EditModel : PageModel
    {
        public void OnGet()
        {
        }


        [BindProperty]
        public Edit edit { get; set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                string message = edit.GetInfo();
                ViewData["message"] = message;
            }
            return Page();
        }
    }
}
