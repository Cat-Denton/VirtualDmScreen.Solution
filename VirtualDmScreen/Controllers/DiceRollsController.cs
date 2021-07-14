using Microsoft.AspNetCore.Mvc;
using VirtualDmScreen.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using System;

namespace VirtualDmScreen.Controllers
{
  public class DiceRollsController : Controller
  {
    private readonly VirtualDmScreenContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    
    public DiceRollsController(UserManager<ApplicationUser> userManager, VirtualDmScreenContext db)
    {
      _db = db;
      _userManager = userManager;
    }

    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Create()
    {
      ViewBag.diceRolls = _db.DiceRolls.ToList();
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(DiceRoll diceRoll)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      diceRoll.RollDice();
      diceRoll.DateTimeStamp = DateTime.Now;
      diceRoll.Character = currentUser.Character;
      _db.DiceRolls.Add(diceRoll);
      _db.SaveChanges();
      return RedirectToAction("Index", "Home");
    }
  }
}