using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CreatingCustomValidationAttributes.Data.Models;

namespace CreatingCustomValidationAttributes.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger) {
        _logger = logger;
    }

    [BindProperty]
    public CurrencyConversionModel _currencyConversionModel { get; set; }

    public void OnPost() {
        if(ModelState.IsValid) {
            _logger.LogDebug(message: _currencyConversionModel.ToString());
        } else {
            _logger.LogDebug(message: "ModelState is invalid. ModelState errors: " + ModelState);
        }
    }

    public void OnGet() { }
}
