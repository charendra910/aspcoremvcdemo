﻿using aspcoredemo.Data;
using aspcoredemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var students = db.student.ToList();
            return View(students);
           
        }

        public IActionResult Add()
        {
            
            return View();
        }


        [HttpPost]
        public IActionResult Add(studentregister studentregister)
        {
            db.student.Add(studentregister);
            db.SaveChanges();
            return RedirectToAction("Display");
        }


        public IActionResult Edit(int id)
        {
            var students = db.student.Find(id);
            if(students == null)
            {
                return NotFound();
            }
            else
            {
                db.student.Update(students);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
       
    }
}
