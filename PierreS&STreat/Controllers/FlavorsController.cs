using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using PierreS_STreat.Models;
using Newtonsoft.Json;

namespace PierreS_STreat.Controllers
{
    [Authorize]
    public class FlavorsController : Controller
    {
        private readonly PierreS_STreatContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        public FlavorsController(UserManager<ApplicationUser> userManager, PierreS_STreatContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            List<Flavor> model = _db.Flavors.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Flavor flavor, int TreatId)
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
            flavor.User = currentUser;
            _db.Flavors.Add(flavor);

            if (TreatId != 0)
            {
                _db.FlavorTreat.Add(new FlavorTreat() { TreatId = TreatId, FlavorId = flavor.FlavorId });
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public ActionResult Details(int id)
        {
            Flavor thisFlavor = _db.Flavors
              .Include(flavor => flavor.Treats)
                .ThenInclude(join => join.Treat)
              .FirstOrDefault(flavor => flavor.FlavorId == id);
            return View(thisFlavor);
        }
    }
}