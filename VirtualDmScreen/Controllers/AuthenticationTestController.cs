using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using VirtualDmScreen.Models;

namespace VirtualDmScreen.Controllers
{
    public class AuthenticationTestController : Controller
    {
        private readonly VirtualDmScreenContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthenticationTestController(UserManager<ApplicationUser> userManager, VirtualDmScreenContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        [Authorize]
        public async Task<ActionResult> Index()
        {   
            Console.WriteLine("hiii");
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
            Console.WriteLine(currentUser.UserName);
            return View();
        }

        public async Task<ActionResult> DmPage()
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
            Console.WriteLine(currentUser.UserName);
            return View();
        }
    }
}
