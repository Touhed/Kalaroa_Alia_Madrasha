using System;
using System.Collections.Generic;
using Kalaroa_Alia_Madrasha.DataBase;
using Kalaroa_Alia_Madrasha.Models;
using Microsoft.AspNetCore.Mvc;


namespace Kalaroa_Alia_Madrasha.Controllers
{
    [Area("Actor")]
    public class ActorController : Controller
    {
        private readonly DataContext db;
        public ActorController(DataContext x)
        {
            db = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewActor(Actor a)
        {
            if (ModelState.IsValid)
            {
                Actor t = new Actor();
                t.UserId = a.UserId;
                t.UserType = a.UserType;
                db.Actor.Add(t);
                db.SaveChanges();
                ViewBag.Success = "New Actor Added Successfully.";
                ModelState.Clear();
            }
            return View();
            //return Redirect("ViewActorList");

        }
        public IActionResult AddNewActor()
        {
            return View();
        }

        public IActionResult ActorList()
        {
            var bci = db.Actor;
            var i = new List<Actor>();
            foreach (var a in bci)
            {
                Actor t = new Actor();
                t.UserId = a.UserId;
                t.UserType = a.UserType;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewActorList()
        {
            var bci = db.Actor;
            var i = new List<Actor>();
            foreach (var a in bci)
            {
                Actor t = new Actor();
                t.UserId = a.UserId;
                t.UserType = a.UserType;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ActorDetails(Int64 Id)
        {
            var j = db.Actor.Find(Id);
            return View(j);
        }

        public IActionResult Search(Int64 Id)
        {
            var l = db.Actor.Find(Id);
            return View(l);
        }


        public IActionResult EditActor(Int64 Id)
        {
            var l = db.Actor.Find(Id);
            return View(l);
        }

        [HttpPost]
        public IActionResult EditActor(Actor a)
        {
            if (ModelState.IsValid)
            {
                Actor t = new Actor();
                t.UserId = a.UserId;
                t.UserType = a.UserType;
                db.Actor.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewActorList");
        }
        
        public IActionResult DeleteActor(Int64 Id)
        {
            var l = db.Actor.Find(Id);
            db.Actor.Remove(l);
            db.SaveChanges();
            return View();
        }
    }
}
