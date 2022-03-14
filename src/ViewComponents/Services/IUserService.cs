using ViewComponents;
using System.Collections.Generic;

namespace ViewComponents.Services;

public interface IUserService {
    List<User> GetUsers();
}
