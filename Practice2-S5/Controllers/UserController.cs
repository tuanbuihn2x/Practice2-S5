using Practice2_S5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice2_S5.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        static List<User> Users = new List<User>();
        public ActionResult Index()
        {
            return View(Users);
        }

        public ActionResult Details(User Users)
        {
            return View(Users);
        }
        public ActionResult Create()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(User us)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", us);
            }
            Users.Add(us);
            return RedirectToAction("Index");
        }
    }
}