using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class HelloModel : PageModel
    {
        public string? Name { get; set; }
        public DateTime Now { get; set; }

        public void OnGet()
        {
            this.Name = "Hiroshi Hara";
            this.Now = DateTime.Now;
        }
    }
}
