using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web.Mvc;
using ClaimsDemo.Models;

namespace ClaimsDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            UserInfo model = GetModel();
            return View(model);
        }

        [Authorize]
        public ActionResult Login()
        {
            return RedirectToAction("Index");
        }

        public UserInfo GetModel()
        {
            return new UserInfo
            {
                Name = User.Identity.IsAuthenticated 
                       ? User.Identity.Name 
                       : "friend",
                       Roles = GetRoles(),
            };
        }

        public List<string> GetRoles()
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            if (claimsIdentity == null) return new List<string>();
            return claimsIdentity.Claims.Where(c => c.Type.Equals(ClaimTypes.Role)).Select(c => c.Value).ToList();
        }
    }
}