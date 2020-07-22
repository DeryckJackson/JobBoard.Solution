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
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/jobs/{id}")]
    public ActionResult Show(int id)
    {
      Job foundItem = Job.Find(id);
      return View(foundItem);
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string title, string desc, string contact)
    {
      Job myItem = new Job(title, desc, contact);
      return RedirectToAction("Index");
    }

    [HttpPost("/jobs/delete")]
    public ActionResult DeleteAll()
    {
      Job.ClearAll();
      return View();
    }

    [HttpPost("/jobs/checked")]
    public ActionResult Checked(int[] jobIds)
    {
      foreach (int id in jobIds)
      {
        Job.RemoveAt(id);
      }
      return RedirectToAction("Index");
    }

  }
}
