using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class AddUserController : Controller
    {
        // GET: AddUser
        public ActionResult AddUser()
        {
            return View();
        }
        public ActionResult AddUser(Person NewUser)
        {
            return View(NewUser);
        }
    }
}