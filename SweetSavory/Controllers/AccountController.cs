using System.Net.Mime;
using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SweetSavory.Models;
using System.Threading.Tasks;
using SweetSavory.ViewModels;

namespace SweetSavory.Controllers
{
  public class AccountController : Controller
  {
    private readonly SweetSavoryContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, SweetSavoryContext db)
    {
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
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register (RegisterViewModel model)
    {
      var user = new ApplicationUser { UserName = model.UserName };
      IdentityResult result = await _userManager.CreateAsync(user, model.Password);
      if (result.Succeeded)
      {
        return RedirectToAction("Login");
      }
      else
      {
        return RedirectToAction("Error");
      }
    }

    public ActionResult Login()
    {
      return View();
    }
    
  }
}