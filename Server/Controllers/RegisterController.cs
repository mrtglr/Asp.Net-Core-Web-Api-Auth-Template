using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Server.Models;

namespace Server.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/[controller]")]
    public class RegisterController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;

        public RegisterController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpPost]
        // route: /api/Register
        public async Task<Object> Register([FromBody] RegisterModel registerModel)
        {
            var applicationUser = new ApplicationUser()
            {
                UserName = registerModel.UserName,
                Email = registerModel.Email,
                PhoneNumber = registerModel.PhoneNumber,
            };

            try
            {
                var result = await _userManager.CreateAsync(applicationUser, registerModel.Password);
                return Ok(result);
            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
