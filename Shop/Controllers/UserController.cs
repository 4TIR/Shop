using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class UserController : Controller
    {
        private readonly IAllUser allUser;

        public UserController(IAllUser allUser)
        {
            this.allUser = allUser;

        }
        public IActionResult signUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult signUp(User user)
        {
            if (ModelState.IsValid)
            {
                try {
                    allUser.createUser(user);

                    return RedirectToAction("Complete");
                }
                catch
                {
                    return RedirectToAction("Email");
                }
                }
           
            return View(user);

        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(User user)
        {
            if (ModelState.IsValid)
            {
                   // allUser.signIn(user);
                    // return View();
                    return RedirectToAction("Complete");
               
            }
          return View();
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Thank you :)";
            return View();

        }
        public IActionResult Email()
        {
            ViewBag.Message = "Email already exists";
            return View();

        }
    }
}
