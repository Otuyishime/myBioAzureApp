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

        // GET: Home
        public ActionResult Contact()
        {
            return View();
        }

        // GET: Home
        public ActionResult Projects()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ContactMe(Email email)
        {
            if (ModelState.IsValid)
            {
                // send email
                try
                {
                    CustomEmail.SendEmailNotification(email: email, receiver: "oliviertyishime@gamil.com");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error from failed send notifications: " + ex.Message);
                }

            }
            return new EmptyResult();
        }
    }
}