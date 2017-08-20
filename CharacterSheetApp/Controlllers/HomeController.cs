/* Basic =============================================== */

using Microsoft.AspNet.Mvc;
using System;

namespace CharacterSheetApp.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      var name = "Shield"
      return View("Index", name);
    }
  }
}

/* Using the Equipment Model: =============================================== */

using Microsoft.AspNet.Mvc;
using CharacterSheetApp.Models;
using System;

namespace CharacterSheetApp.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      var model = new Equipment();
      model.Name = "Shield";
      return View("Index", model);
    }
  }
} 

/* Getting User Input =============================================== */

using Microsoft.AspNet.Mvc;
using CharacterSheetApp.Models;
using System;

namespace CharacterSheetApp.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      Equipment model = new Equipment();
      model.Name = "Shield";
      return View("Index", model);
    }
     
    //create our Create Action here
     public IActionResult Create(string EquipmentName)
     {
       var model = new CharacterSheetApp.Models.Equipment();
       model.Name = EquipmentName;
       return View(model);
     }
     
  } 

  /* Retaining Data (so it doesnt overwrite previous input)=============================================== */

using Microsoft.AspNet.Mvc;
using CharacterSheetApp.Models;
using System;

namespace CharacterSheetApp.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View(Equipment.GetAll());
    }

    public IActionResult Create(string EquipmentName)
    {
      Equipment.Create(EquipmentName);
      return RedirectToAction("Index");
    }
  }
}