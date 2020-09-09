using System;
using System.Collections.Generic;
using Kalaroa_Alia_Madrasha.DataBase;
using Kalaroa_Alia_Madrasha.Models;
using Microsoft.AspNetCore.Mvc;


namespace Kalaroa_Alia_Madrasha.Controllers
{
    [Area("Teacher")]
    public class TeacherController : Controller
    {
        private readonly DataContext db;
        public TeacherController(DataContext x)
        {
            db = x;
        }
        public IActionResult Index(string a)
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTeacher(Teacher r)
        {
            if (ModelState.IsValid)
            {
                Teacher t = new Teacher();
                t.Id = r.Id;
                t.Name = r.Name;
                t.Designation = r.Designation;
                t.Contact = r.Contact;
                t.Address = r.Address;
                t.Email = r.Email;
                t.Photo = r.Photo;
                db.Teacher.Add(t);
                db.SaveChanges();
                ViewBag.Success = "New Teacher Added Successfully.";
                ModelState.Clear();
            }
            return View();
            //return Redirect("ViewTeacherList");
        }
        public IActionResult AddTeacher()
        {
            return View();
        }

        public IActionResult TeacherList()
        {
            var test = db.Teacher;
            var i = new List<Teacher>();
            foreach (var f in test)
            {
                Teacher t = new Teacher();
                t.Id = f.Id;
                t.Name = f.Name;
                t.Designation = f.Designation;
                t.Contact = f.Contact;
                t.Address = f.Address;
                t.Email = f.Email;
                t.Photo = f.Photo;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewTeacherList()
        {
            var test = db.Teacher;
            var i = new List<Teacher>();
            foreach (var f in test)
            {
                Teacher t = new Teacher();
                t.Id = f.Id;
                t.Name = f.Name;
                t.Designation = f.Designation;
                t.Contact = f.Contact;
                t.Address = f.Address;
                t.Email = f.Email;
                t.Photo = f.Photo;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult Search(Int64 Id)
        {
            var l = db.Teacher.Find(Id);
            return View(l);
        }

        public IActionResult TeacherDetails(Int64 Id)
        {
            var l = db.Teacher.Find(Id);
            return View(l);
        }
        public IActionResult EditTeacher(Int64 Id)
        {
            var l = db.Teacher.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditTeacher(Teacher f)
        {
            if (ModelState.IsValid)
            {
                Teacher t = new Teacher();
                t.Id = f.Id;
                t.Name = f.Name;
                t.Designation = f.Designation;
                t.Contact = f.Contact;
                t.Address = f.Address;
                t.Email = f.Email;
                t.Photo = f.Photo;
                db.Teacher.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewTeacherList");
        }

        public IActionResult DeleteTeacher(Int64 Id)
        {
            var l = db.Teacher.Find(Id);
            db.Teacher.Remove(l);
            db.SaveChanges();
            return View();
        }
    }
}

/*
public IActionResult FacultyOne()
{
    var test = db.Faculty.FirstOrDefault();

    Faculty Sent = new Faculty()
    {
        Id = test.Id,
        Name = test.Name,
        Designation = test.Designation,
        Contact = test.Contact,
        Address = test.Address,
        Email = test.Email
        Photo = test.Photo;
    };

    return View(Sent);
}
*/