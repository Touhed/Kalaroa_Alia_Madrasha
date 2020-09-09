﻿using System;
using System.Collections.Generic;
using System.IO;
using Kalaroa_Alia_Madrasha.DataBase;
using Kalaroa_Alia_Madrasha.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kalaroa_Alia_Madrasha.Controllers
{
    [Area("Student")]
    public class StudentController : Controller
    {
        private readonly DataContext db;
        public StudentController(DataContext x)
        {
            db = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student s)
        {
            if (ModelState.IsValid)
            {
                Student t = new Student();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.FatherName = s.FatherName;
                t.MotherName = s.MotherName;
                t.Department = s.Department;
                t.Class = s.Class;
                t.Section = s.Section;
                t.Scholarship = s.Scholarship;
                t.Session = s.Session;
                t.Nationality = s.Nationality;
                t.DOB = s.DOB;
                t.Gender = s.Gender;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                t.Photo = s.Photo;
                db.Student.Add(t);
                db.SaveChanges();
                ViewBag.Success = "New Student Added Successfully.";
                ModelState.Clear();
            }
            return View();
            //return Redirect("ViewStudentList");
        }
        public IActionResult AddStudent()
        {
            return View();
        }
        
        public IActionResult StudentList()
        {
            var test = db.Student;
            var i = new List<Student>();
            foreach (var s in test)
            {
                Student t = new Student();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.FatherName = s.FatherName;
                t.MotherName = s.MotherName;
                t.Department = s.Department;
                t.Class = s.Class;
                t.Section = s.Section;
                t.Scholarship = s.Scholarship;
                t.Department = s.Department;
                t.Session = s.Session;
                t.Nationality = s.Nationality;
                t.DOB = s.DOB;
                t.Gender = s.Gender;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                t.Photo = s.Photo;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewStudentList()
        {
            var test = db.Student;
            var i = new List<Student>();
            foreach (var s in test)
            {
                Student t = new Student();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.FatherName = s.FatherName;
                t.MotherName = s.MotherName;
                t.Department = s.Department;
                t.Class = s.Class;
                t.Section = s.Section;
                t.Scholarship = s.Scholarship;
                t.Department = s.Department;
                t.Session = s.Session;
                t.Nationality = s.Nationality;
                t.DOB = s.DOB;
                t.Gender = s.Gender;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                t.Photo = s.Photo;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult Search(Int64 Id)
        {
            var l = db.Student.Find(Id);
            return View(l);
        }

        public IActionResult StudentDetails(Int64 Id)
        {
            var n = db.Student.Find(Id);
            return View(n);
        }

        public IActionResult EditStudent(Int64 Id)
        {
            var l = db.Student.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditStudent(Student s)
        {
            if (ModelState.IsValid)
            {
                Student t = new Student();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.FatherName = s.FatherName;
                t.MotherName = s.MotherName;
                t.Department = s.Department;
                t.Class = s.Class;
                t.Section = s.Section;
                t.Scholarship = s.Scholarship;
                t.Department = s.Department;
                t.Session = s.Session;
                t.Nationality = s.Nationality;
                t.DOB = s.DOB;
                t.Gender = s.Gender;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                t.Photo = s.Photo;
                db.Student.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewStudentList");
        }
        
        public IActionResult DeleteStudent(Int64 Id)
        {
            var l = db.Student.Find(Id);
            db.Student.Remove(l);
            db.SaveChanges();
            return View();
        }
    }
}
