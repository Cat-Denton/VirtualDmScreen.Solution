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
      List<DiceRoll> diceRolls = _db.DiceRolls.ToList();
      return View(diceRolls);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(DiceRoll diceRoll)
    {
      diceRoll.RollDice();
      diceRoll.DateTimeStamp = DateTime.Now;
      Console.WriteLine(diceRoll.Result + " " + diceRoll.DateTimeStamp);
      diceRoll.CharacterId = 1;
      _db.DiceRolls.Add(diceRoll);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}