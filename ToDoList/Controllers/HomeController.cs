using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using ToDoList.Models;
=======
>>>>>>> object-ions/main

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {

<<<<<<< HEAD
    [Route("/")]
    public ActionResult Index()
    {
      Item starterItem = new Item("Add first item to To Do List");
      return View(starterItem);
=======
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
>>>>>>> object-ions/main
    }

  }
}