using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookGallery.Controllers
{
  public class BooksController : Controller
  {
    public ActionResult Detail()
    {
      if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
        return Redirect("/");

      return new ContentResult()
      {
        Content = "Hello from the book controller!"
      };
    }
  }
}