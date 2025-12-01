using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementAppWeb.Models;

namespace SchoolManagementAppWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register reg)
        {
            if (ModelState.IsValid)
            {
                var identityUser = new IdentityUser
                {
                    UserName = reg.Username,
                    Email = reg.Email
                };

                var identityResult = await userManager.CreateAsync(identityUser, reg.Password);

                if (identityResult.Succeeded)
                {
                    // assign this user the "User" role
                    var roleIdentityResult = await userManager.AddToRoleAsync(identityUser, "Student");

                    if (roleIdentityResult.Succeeded)
                    {
                        // Show success notification
                        return RedirectToAction("Register");
                    }
                }
            }

            // Show error notification
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login Login)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var signInResult = await signInManager.PasswordSignInAsync(Login.Username,
                Login.Password, false, false);

            if (signInResult != null && signInResult.Succeeded)
            {
                if (!string.IsNullOrWhiteSpace(Login.ReturnUrl))
                {
                    return Redirect(Login.ReturnUrl);
                }

                return RedirectToAction("Index", "Home");
            }

            // Show errors
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
