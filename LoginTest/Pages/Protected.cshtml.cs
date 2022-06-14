using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginTest.Pages
{
    [Authorize]
    public class ProtectedModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
