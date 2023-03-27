using Microsoft.AspNetCore.Identity;
using System.Diagnostics.CodeAnalysis;

namespace Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Custom variables here...
    }

    public class RegisterModel : IdentityUser
    {
        public string? Password { get; set; }
    }

    public class LoginModel : RegisterModel
    {

    }
}
