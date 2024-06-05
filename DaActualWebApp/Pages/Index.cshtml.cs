using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DaActualWebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public string? InputText { get; set; }

    public string? Message { get; set; }

    public void OnGet()
    {
        // This method is called when the page is requested via HTTP GET
    }

    public IActionResult OnPost()
    {
        // This method is called when the page receives an HTTP POST request

        Message = CalcSecret(InputText ?? "");

        return Page();
    }

    public string CalcSecret(string inputText) {

        return inputText switch
        {
            "secret" => "You entered the secret!",
            _ => "You Failed"
        };

    }


}
