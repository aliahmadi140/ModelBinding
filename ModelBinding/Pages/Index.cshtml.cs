using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ModelBinding.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        [BindProperty]
        public IList<string> Animals { get; set; }


       public IActionResult OnPost()
        {
            TempData["Animals"]= Animals;
            return RedirectToPage("./Result");
        }
    }
}