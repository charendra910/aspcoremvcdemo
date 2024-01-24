using aspcoredemo.Data;
using aspcoredemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspcoredemo.Controllers
{
    public class Studentregister1 : Controller
    {
        private studentdbcontext db;

        public Studentregister1(studentdbcontext db)
        { 
            this.db = db; 
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}


//private studentdbcontext db;
//public studentregistercontroller(studentdbcontext db)
//{
//    this.db = db;

//}


//public iactionresult index()
//{
//    ienumerable<studentregister> students = db.students;
//    return view(students);

//}

//public iactionresult create()
//{
//    return view();

//}