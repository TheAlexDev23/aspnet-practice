using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AntiForgery.Pages;

public class IndexModel : PageModel {
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger) {
        _logger = logger;
    }

    public void OnGet() {

    }


    [BindProperty]
    public LoginModel LogInBindingModel {get; set;}


    [ValidateAntiForgeryToken]
    public void OnPost() {
        _logger.LogInformation(LogInBindingModel.UserName);
    }

    public class LoginModel {
        [StringLength(maximumLength: 150, ErrorMessage = "Name cannot be larger than 150 characters")]
        [Required(ErrorMessage = "This field is required")]
        public string UserName {get; set;}
    }
}
