using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace razor_page.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;

    [Display(Name = "Client Time")]
    [DataType(DataType.Time)]
    public DateTimeOffset ClientTime { get; set; } = DateTimeOffset.UtcNow;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        Title = "Home page 2 from model";
        ClientTime = DateTimeOffset.UtcNow;
    }

    public void OnGet()
    {

    }
}
