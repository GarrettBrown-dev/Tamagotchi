using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class PetsController : Controller
  {

    [HttpGet("/pets")]
    public ActionResult Index()
    {
      List<Pet> allPets = Pet.GetAll();
      return View(allPets);
    }

    [HttpGet("/pets/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/pets")]
    public ActionResult Create(string name, string image)
    {
      Pet myPet = new Pet(name, image);
      return RedirectToAction("Index");
    }

    [HttpGet("/pets/{id}")]
    public ActionResult Show(int id)
    {
      Pet foundPet = Pet.Find(id);
      return View(foundPet);
    }

    [HttpPost("/pets/{id}/feed")]
    public ActionResult Feed(int id)
    {
      Pet foundPet = Pet.Find(id);
      foundPet.Feed();
      return RedirectToAction("Show");    //RediredtToAction("Show", new { id = })
    }
    [HttpPost("/pets/{id}/play")]
    public ActionResult Play(int id)
    {
      Pet foundPet = Pet.Find(id);
      foundPet.Play();
      return RedirectToAction("Show");    //RediredtToAction("Show", new { id = })
    }
    [HttpPost("/pets/{id}/sleep")]
    public ActionResult Sleep(int id)
    {
      Pet foundPet = Pet.Find(id);
      foundPet.Sleep();
      return RedirectToAction("Show");    //RediredtToAction("Show", new { id = })
    }
  }
}

