using System;
using System.Collections.Generic;
using System.Linq;
using Kalaroa_Alia_Madrasha.DataBase;
using Kalaroa_Alia_Madrasha.Models;
using Kalaroa_Alia_Madrasha.ViewModel;
using Microsoft.AspNetCore.Mvc;


namespace Kalaroa_Alia_Madrasha.Controllers
{
    [Area("Result")]
    public class ResultController : Controller
    {
        private readonly DataContext db;
        public ResultController(DataContext x)
        {
            db = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewResult(Result r)
        {
            if (ModelState.IsValid)
            {
                Result t = new Result();
                t.StudentId = r.StudentId;
                t.StudentName = r.StudentName;
                t.SClass = r.SClass;
                t.Subject = r.Subject;
                t.Marks = r.Marks;
                db.Result.Add(t);
                db.SaveChanges();
                ViewBag.Success = "New Result Added Successfully.";
                ModelState.Clear();
            }
            return View();
            //return Redirect("ViewResultList");
        }
        public IActionResult AddNewResult()
        {
            return View();
        }

        public IActionResult EditResult(Int64 Id)
        {
            var l = db.Result.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditResult(Result r)
        {
            if (ModelState.IsValid)
            {
                Result t = new Result();
                t.StudentId = r.StudentId;
                t.StudentName = r.StudentName;
                t.SClass = r.SClass;
                t.Subject = r.Subject;
                t.Marks = r.Marks;
                db.Result.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewResultList");
        }
        
        public IActionResult DeleteResult(Int64 Id)
        {
            var l = db.Result.Find(Id);
            db.Result.Remove(l);
            db.SaveChanges();
            return View();
        }

        public IActionResult ResultList()
        {
            var reg = db.Result;
            var i = new List<ResultVM>();
            foreach (var t in reg)

            {
                ResultVM r = new ResultVM();
                r.StudentId = t.StudentId;
                r.StudentName = t.StudentName;
                r.SClass = t.SClass;
                r.Subject = t.Subject;
                r.Marks = t.Marks;
                i.Add(r);
            };
            return View(i);
        }

        public IActionResult ViewResultList()
        {
            var reg = db.Result;
            var i = new List<ResultVM>();
            foreach (var t in reg)

            {
                ResultVM r = new ResultVM();
                r.StudentId = t.StudentId;
                r.StudentName = t.StudentName;
                r.SClass = t.SClass;
                r.Subject = t.Subject;
                r.Marks = t.Marks;
                i.Add(r);
            };
            return View(i);
        }

        public IActionResult Search(Int64 Id)
        {
            var l = db.Result.Find(Id);
            return View(l);
        }

        public IActionResult ResultDetails(Int64 Id)
        {
            var r = db.Result.Find(Id);
            return View(r);
        }

        public IActionResult Class_1(Int64 Id)
        {
            var rs = db.Result.ToList();
            var a = db.Student.ToList();
            var i = new List<ResultVM>();
            var query = (from s in a
                         join r in rs on s.StudentId equals r.StudentId
                         select new
                         {
                             StudentId = s.StudentId,
                             StudentName = s.StudentName,
                             Session = s.Session,
                             Department = s.Department,
                             Class = s.Class,
                             ExamType = r.ExamType,
                             Subject = r.Subject,
                             Marks = r.Marks
                         });
            foreach (var t in rs)
            {
                ResultVM r = new ResultVM();
                r.StudentId = t.StudentId;
                r.StudentName = t.StudentName;
                r.StSession = t.StSession;
                r.SDepartment = t.SDepartment;
                r.SClass = t.SClass;
                r.Subject = t.Subject;
                r.Marks = t.Marks;
                i.Add(r);
            };
            var l = db.Result.Find(Id);
            return View(i);
        }

        public IActionResult Class_2()
        {
            return View();
        }

        public IActionResult Class_3()
        {
            return View();
        }

        public IActionResult Class_4()
        {
            return View();
        }

        public IActionResult Class_5()
        {
            return View();
        }

        public IActionResult Class_6()
        {
            return View();
        }

        public IActionResult Class_7()
        {
            return View();
        }

        public IActionResult Class_8()
        {
            return View();
        }

        public IActionResult Class_9()
        {
            return View();
        }

        public IActionResult Class_10()
        {
            return View();
        }

        public IActionResult Alim_1st_Year()
        {
            return View();
        }

        public IActionResult Alim_2nd_Year()
        {
            return View();
        }
    }
}
