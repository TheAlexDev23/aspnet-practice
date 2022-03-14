using System.Collections.Generic;

namespace ViewComponents.Services;

public class UserService : IUserService {
    public List<User> GetUsers() => 
        new List<User>() {
            new User() {
                Name = "TheAlexDev",
                Age  = 13
            },
            new User() {
                Name = "Sam",
                Age  = 25
            },
            new User() {
                Name = "John",
                Age  = 45
            },
            new User() {
                Name = "Tom",
                Age  = 59,
            }
        };
    
}
