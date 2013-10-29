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

        public UserInfo GetModel()
        {
            return new UserInfo
            {
                Name = User.Identity.IsAuthenticated 
                       ? User.Identity.Name 
                       : "friend",
            };
        }
    }
}