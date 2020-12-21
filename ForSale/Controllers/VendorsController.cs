using Microsoft.AspNetCore.Mvc;
using ForSale.Models;
using System.Collections.Generic;

namespace ForSale.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("vendors/new")]
    public ActionResult New()
    {
      return View();
    }
  }

}