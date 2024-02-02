using aspcoredemo.Data;
using Microsoft.AspNetCore.Mvc;

namespace aspcoredemo.Controllers
{
    public class AddStudentController1 : Controller
    {
        private studentdbcontext db;

        public AddStudentController1(studentdbcontext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
