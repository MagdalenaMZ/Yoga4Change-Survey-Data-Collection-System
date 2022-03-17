using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yoga4Change_Survey_Data_Collection_System.Areas.Identity.Data;
using Yoga4Change_Survey_Data_Collection_System.Models;
using Yoga4Change_Survey_Data_Collection_System.Repositories.Interfaces;

namespace Yoga4Change_Survey_Data_Collection_System.Controllers
{
    public class UserController : Controller
    {
        UserManager<Y4CUser> userManager;
        RoleManager<IdentityRole> roleManager;
        private readonly IUserRepository _userRepository; 
        public UserController(UserManager<Y4CUser> userManager, IUserRepository _userRepository)
        {
            this._userRepository = _userRepository;
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            var users = userManager.Users.ToList();
            return View(users);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteUser(string Id)
        {
            var user = await userManager.FindByIdAsync(Id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                var result = await userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("Index");
            }
        }
        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _userRepository.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }


            // GetRolesAsync returns the list of user Roles
            var userRoles = await _userRepository.GetRoleListAsync();

            var model = new EditUserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                FullName = user.FullName,
                Roles = userRoles
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.Id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                user.Email = model.Email;
                user.UserName = model.UserName;
                user.FullName = model.FullName;

                var result = await userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("I");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
        }
    }

}


