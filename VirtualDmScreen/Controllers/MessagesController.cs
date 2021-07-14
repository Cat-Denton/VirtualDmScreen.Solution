using System;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VirtualDmScreen.Models;

namespace VirtualDmScreen.Controllers
{
  //[Authorize]
  public class MessagesController : Controller
  {
    private readonly VirtualDmScreenContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public MessagesController(UserManager<ApplicationUser> userManager, VirtualDmScreenContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Index()
    {
        return View(_db.Messages.ToList());
    }

    [HttpPost]
    //Should pass in DiceRoll and Message classes?
    public async Task<ActionResult> Create(Message message)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      message.DateTimeStamp = DateTime.Now;
      message.Character = new Character() { Name = "Jon Snow"};
      _db.Messages.Add(message);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
