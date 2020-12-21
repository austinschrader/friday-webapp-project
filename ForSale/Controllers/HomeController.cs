using Microsoft.AspNetCore.Mvc;
using ForSale.Models;
using System.Collections.Generic;

namespace ForSale.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}