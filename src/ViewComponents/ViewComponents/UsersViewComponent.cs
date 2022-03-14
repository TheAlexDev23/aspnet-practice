using Microsoft.AspNetCore.Mvc;
using ViewComponents.Services;
using ViewComponents;

namespace ViewComponents.ViewComponents;

public class UsersViewComponent : ViewComponent {
    private IUserService _userService;

    public UsersViewComponent(IUserService userService) {
        _userService = userService; 
    }

    public IViewComponentResult Invoke() {
        var users = _userService.GetUsers();
        return View(users);
    }
}
