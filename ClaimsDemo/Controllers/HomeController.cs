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
            return View();
        }
    }
}