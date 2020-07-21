using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobsController : Controller
  {

    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<Job> allItems = Job.GetAll();
      return View(allItems);
    }

    [HttpGet("/jobs/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string title, string desc, string contact)
    {
      Job myItem = new Job(title, desc, contact);
      return RedirectToAction("Index");
    }

  }
}
