using Microsoft.AspNetCore.Mvc;
using ZakupkiWebApp_asp_net_core.Models;

namespace ZakupkiWebApp_asp_net_core.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index() // contacts/about
        {
            return View();
        }
        [HttpPost]
        public IActionResult Check(Contact contact) // contacts/about
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Index");

        }

    }
}
