using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace razor_page.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    [Display(Name = "Client Time")]
    [DataType(DataType.Time)]
    public DateTimeOffset ClientTime { get; set; } = DateTimeOffset.UtcNow;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
        ClientTime = DateTimeOffset.UtcNow;
    }

    public void OnGet()
    {
    }
}

