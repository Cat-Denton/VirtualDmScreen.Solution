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
    public class HomeController : Controller
    {

        private readonly VirtualDmScreenContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        public HomeController(UserManager<ApplicationUser> userManager, VirtualDmScreenContext db)
        {
        _userManager = userManager;
        _db = db;
        }

        public IActionResult Index()
        {
            List<DmTrackSelection> tracks = _db.DmTrackSelections.ToList();
            ViewBag.DmTrackSelectionId = new SelectList(_db.DmTrackSelections, "DmTrackSelectionId", "TrackName");
            ViewBag.DmImgSelectionId = new SelectList(_db.DmImgSelections, "DmImgSelectionId", "ImgName");
            var dmSelections = _db.DmChoices.FirstOrDefault(selection => selection.DmChoiceId == 1);
            DmTrackSelection dmTrackSelection = dmSelections.DmTrackSelection;
            DmImgSelection dmImgSelection = dmSelections.DmImgSelection;
            ViewBag.SelectedTrack = dmTrackSelection;
            ViewBag.SelectedImg = dmImgSelection;
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
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
