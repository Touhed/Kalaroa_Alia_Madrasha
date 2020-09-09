using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Kalaroa_Alia_Madrasha.DataBase;
using Kalaroa_Alia_Madrasha.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kalaroa_Alia_Madrasha.Controllers
{
    [Area("Users")]
    public class UsersController : Controller
    {
        private readonly DataContext db;

        public UsersController(DataContext x)
        {
            db = x;
        }
        public IActionResult Index()
        {
            return View();
        }

        // Login Methode Start

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (HttpContext.Session.Get("userName") != null)
            {
                return View();
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Login(Users model)
        {
            var user = db.Users.Where(u => u.Email == model.Email && u.Password == model.Password).FirstOrDefault();
            if (!ModelState.IsValid && user != null)
            {
                string username = user.FirstName + user.LastName;
                HttpContext.Session.Get("userName");

                if (user.UserType.Equals("Admin"))
                {
                    return RedirectToAction("AdminLogin", "Users", new { userName = username });
                }
                else if (user.UserType.Equals("Teacher"))
                {
                    return RedirectToAction("Index", "Teacher", new { userName = username });
                }
                else if (user.UserType.Equals("Student"))
                {
                    return RedirectToAction("Index", "Student", new { userName = username });
                }
                else if (user.UserType.Equals("Account"))
                {
                    return RedirectToAction("Index", "Account", new { userName = username });
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ViewBag.Login = "User Name or Password Invalid!!!";
				return RedirectToAction("Login");
            }
        }
        
        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("userName");
            return RedirectToAction("Users", "Login");
        }
        

        public IActionResult AdminLogin()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CreateUserAccount(Users c)
        {
            if (ModelState.IsValid)
            {
                Users t = new Users
                {
                    LoginId = c.LoginId,
                    UserId = c.UserId,
                    UserType = c.UserType,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Email = c.Email,
                    Password = c.Password,
                };
                db.Users.Add(c);
                db.SaveChanges();
                ViewBag.Success = "User Account Created Successfully.";
                ModelState.Clear();
            }
            return View();
            //return RedirectToAction("ViewUserList");
        }
        public IActionResult CreateUserAccount()
        {
            return View();
        }

        public IActionResult UserList()
        {
            var test = db.Users;
            var i = new List<Users>();
            foreach (var l in test)
            {
                Users t = new Users();
                t.LoginId = l.LoginId;
                t.UserId = l.UserId;
                t.UserType = l.UserType;
                t.FirstName = l.FirstName;
                t.LastName = l.LastName;
                t.Email = l.Email;
                t.Password = l.Password;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewUserList()
        {
            var test = db.Users;
            var i = new List<Users>();
            foreach (var l in test)
            {
                Users t = new Users();
                t.LoginId = l.LoginId;
                t.UserId = l.UserId;
                t.UserType = l.UserType;
                t.FirstName = l.FirstName;
                t.LastName = l.LastName;
                t.Email = l.Email;
                t.Password = l.Password;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult UserDetails(Int64 Id)
        {
            var i = db.Users.Find(Id);
            return View(i);
        }

        public IActionResult Search(Int64 Id)
        {
            var l = db.Users.Find(Id);
            return View(l);
        }

        public IActionResult EditUserDetails(Int64 Id)
        {
            var l = db.Users.Find(Id);
            return View(l);
        }

        [HttpPost]
        public IActionResult EditUserDetails(Users c)
        {
            if (ModelState.IsValid)
            {
                Users t = new Users
                {
                    LoginId = c.LoginId,
                    UserId = c.UserId,
                    UserType = c.UserType,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Email = c.Email,
                    Password = c.Password,
                };
                db.Users.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewUserList");
        }

        public IActionResult DeleteUserData(Int64 Id)
        {
            var l = db.Users.Find(Id);
            db.Users.Remove(l);
            db.SaveChanges();
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}