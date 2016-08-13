using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller // need to be public, or MVC can't find or call it
    {
        public string Detail()
        {
            return "Hello from the comic book controller";
        }
    }
}