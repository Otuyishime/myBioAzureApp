using myBioApp.Models;
using System;
using System.Web.Mvc;

namespace myBioApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        [ActionName(name: "Contact")]
        public ActionResult Contact_Get()
        {
            return View();
        }

        // GET: Home
        public ActionResult Projects()
        {
            return View();
        }

        [HttpPost]
        [ActionName(name: "Contact")]
        public ActionResult Contact_Post(Email email)
        {
            if (ModelState.IsValid)
            {
                // send email
                try
                {
                    CustomEmail.SendEmailNotification(email: email);
                    return new RedirectResult("/Home/Contact");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error from failed send notifications: " + ex.Message);
                }

            }
            return View(email);
        }
    }
}