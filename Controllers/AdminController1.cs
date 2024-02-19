using aspcoredemo.Data;
using Microsoft.AspNetCore.Mvc;

namespace aspcoredemo.Controllers
{
    public class AdminController1 : Controller
    {
        private admincontext ad;
        public AdminController1(admincontext ad)
        {
            this.ad = ad;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Adminaddindex ()
        {
            var admins = ad.admin.ToList();
            return View(admins);
        }

    }
}
