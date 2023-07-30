using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesWebApp.Pages;

public class UploadModel : PageModel
{
    private readonly ILogger<UploadModel> _logger;

    public UploadModel(ILogger<UploadModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }

}

