using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Models
{
    public class RazorTestModel : PageModel
    {
        private readonly ILogger<RazorTestModel> _logger;

        public RazorTestModel(ILogger<RazorTestModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

    }
}