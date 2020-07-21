using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobsController : Controller
  {

    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Job> allItems = Job.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string description)
    {
      Job myItem = new Job(description);
      return RedirectToAction("Index");
    }

  }
}
