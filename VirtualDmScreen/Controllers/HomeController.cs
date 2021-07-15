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
    [Authorize]
    public class HomeController : Controller
    {

        private readonly VirtualDmScreenContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        public HomeController(UserManager<ApplicationUser> userManager, VirtualDmScreenContext db)
        {
        _userManager = userManager;
        _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<DmTrackSelection> tracks = _db.DmTrackSelections.ToList();
            ViewBag.DmTrackSelectionId = new SelectList(_db.DmTrackSelections, "DmTrackSelectionId", "TrackName");
            ViewBag.DmImgSelectionId = new SelectList(_db.DmImgSelections, "DmImgSelectionId", "ImgName");
            
            var dmSelections = _db.DmChoices.FirstOrDefault(selection => selection.DmChoiceId == 1);
            DmTrackSelection dmTrackSelection = dmSelections.DmTrackSelection;
            DmImgSelection dmImgSelection = dmSelections.DmImgSelection;
            ViewBag.SelectedTrack = dmTrackSelection;
            ViewBag.SelectedImg = dmImgSelection;
            
            // var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            // var currentUser = await _userManager.FindByIdAsync(userId);
            var characterList = _db.Characters.ToList();
            ViewBag.lastFourChars = characterList.Skip(Math.Max(0, characterList.Count() - 4));

            // Character model = currentUser.Character;
            // Console.WriteLine("************************************" + currentUser.Character.Name + currentUser.Character.BoxId);
            ViewBag.Messages = _db.Messages.ToList();
            ViewBag.DiceRolls = _db.DiceRolls.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Index(int dmTrackSelectionId, int dmImgSelectionId)
        {
            DmChoice newDmChoice = new DmChoice {DmChoiceId = 1, DmTrackSelectionId = dmTrackSelectionId, DmImgSelectionId = dmImgSelectionId};
            _db.Entry(newDmChoice).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EditCharacter(Character character, int boxId, int characterId, string userId)
        {
        //    var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        //     var thisCharacter = _db.Characters.FirstOrDefault(Character => Character.ApplicationUserId == userId);
            Console.WriteLine("Editing " + character.Name);
            character.CharacterId = characterId;
            character.ApplicationUserId = userId;
            Console.WriteLine("CharacterId: " + character.CharacterId);
            Console.WriteLine("User: " + character.User);
            character.BoxId = boxId;
            Console.WriteLine("boxId: " + boxId);
            Console.WriteLine("character.BoxId: " + character.BoxId);
            _db.Entry(character).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> CreateRoll(DiceRoll diceRoll)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            diceRoll.RollDice();
            diceRoll.DateTimeStamp = DateTime.Now;
            diceRoll.Character = currentUser.Character;
            _db.DiceRolls.Add(diceRoll);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
