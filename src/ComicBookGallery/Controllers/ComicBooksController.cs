using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers // need to be public, or MVC can't find and call it
{
    public class ComicBooksController : Controller // need to be public, or MVC can't find and call it
    {
        public ActionResult Detail() // everything inside of controller is an action
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            {
                return Redirect("/");
            }

            return Content("Hello from the comic book controller!");
        }
    }
}