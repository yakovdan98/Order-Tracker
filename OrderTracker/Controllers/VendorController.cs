using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      return View(Vendor.GetAll());
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View(); 
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string desc)
    {
      Vendor newVendor = new Vendor(name, desc);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      return View(Vendor.Find(id));
    }

    [HttpPost("/vendors/{id}/orders")]
    public ActionResult Create(int id, string title, string desc, double price, string date)
    {
      Order order = new Order(title, desc, price, date);
      Vendor.Find(id).AddOrder(order);
      return View("Show", Vendor.Find(id));
    }

    [HttpPost("/vendors/{id}/delete")]
    public ActionResult Delete(int id)
    {
      Vendor.Delete(id);
      return RedirectToAction("Index");
    }
  }
}