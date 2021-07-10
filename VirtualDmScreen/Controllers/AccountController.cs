using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using VirtualDmScreen.Models;
using System.Threading.Tasks;
using VirtualDmScreen.ViewModels;
using System.Linq;

namespace VirtualDmScreen.Controllers
{
  public class AccountController : Controller
  {
    private readonly VirtualDmScreenContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<ApplicationRole> _roleManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    public AccountController (RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, VirtualDmScreenContext db)
    {
        _roleManager = roleManager;
        _userManager = userManager;
        _signInManager = signInManager;
        _db = db;
    }

    public ActionResult Index()
    {
        return View();
    }

    public IActionResult Register()
    {
        ViewBag.RoleId = new SelectList(_db.Roles, "Id", "Name");
        return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register (RegisterViewModel model, string roleId)
    {
        var user = new ApplicationUser { UserName = model.Email };
        var role = await _roleManager.FindByIdAsync(roleId);
        IdentityResult userResult = await _userManager.CreateAsync(user, model.Password);
        IdentityResult roleResult = await _userManager.AddToRoleAsync(user, role.Name);
        if (userResult.Succeeded && roleResult.Succeeded)
        {
            return RedirectToAction("Index");
        }
        else
        {
            return View();
        }
    }

    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
      Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }

    [HttpPost]
    public async Task<ActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index");
    }
  }
}