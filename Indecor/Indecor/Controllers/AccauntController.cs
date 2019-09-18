using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Indecor.DAL;
using Indecor.Models;
using Indecor.Utilities;
using Indecor.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Indecor.Controllers
{
    public class AccauntController : Controller
    {
        private IndecorDataBase _indecordataBase;
        private UserManager<UserControl> _userManager;
        private SignInManager<UserControl> _signManager;
        private RoleManager<IdentityRole> _roleManager;
  
        public AccauntController(IndecorDataBase indecordataBase, UserManager<UserControl> userManager,SignInManager<UserControl> signManager, RoleManager<IdentityRole> roleManager)
        {
            _indecordataBase = indecordataBase;
            _userManager = userManager;
            _signManager = signManager;
            _roleManager = roleManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>  Register(RegisterViewModel registerViewModel)
        {
           if ( registerViewModel == null)
           {
                return View(registerViewModel);
           };
      
            UserControl newUser = new UserControl()
            {
                Name = registerViewModel.Name,
                Surname = registerViewModel.Surname,              
                IdentityCard = registerViewModel.IdentityCard,
                UserName = registerViewModel.Username,
                Email = registerViewModel.Email
            };

            IdentityResult identityResult = await _userManager.CreateAsync(newUser, registerViewModel.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(registerViewModel);
            }

              await _signManager.SignInAsync(newUser, true);

            if (newUser.IdentityCard.StartsWith('A'))
            {
                await _userManager.AddToRoleAsync(newUser, Utility.Roles.Admin.ToString());
            }
            if (newUser.IdentityCard.StartsWith('M'))
            {
                await _userManager.AddToRoleAsync(newUser, Utility.Roles.Meneger.ToString());
            }

            return RedirectToAction("Index", "Home");

        }

        public async Task<IActionResult> Logout()
        {
            await _signManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]  
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid) return View(loginViewModel);
            UserControl find = await _userManager.FindByEmailAsync(loginViewModel.Email);

            if (find == null)
            {
                ModelState.AddModelError("", "Email don't exist in database");
                return View(loginViewModel);
            }

            Microsoft.AspNetCore.Identity.SignInResult login = await _signManager.PasswordSignInAsync(find, loginViewModel.Password, loginViewModel.RememberMe, true);

            if (!login.Succeeded)
            {
                ModelState.AddModelError("", "Email don't exist in database");
                return View(loginViewModel);
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task RoleSeedr()
        {
            if (!await _roleManager.RoleExistsAsync(Utility.Roles.Admin.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Utility.Roles.Admin.ToString()));
            }
            if (!await _roleManager.RoleExistsAsync(Utility.Roles.Meneger.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Utility.Roles.Meneger.ToString()));
            }
          

        }

    }
}