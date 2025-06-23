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
            if (!ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Index");

        }

        [HttpPost]
        public IActionResult Submit(Contact Contacts_feedback)
        {
           

            if (ModelState.IsValid)
            {
                //return View("Index", Contacts_feedback);
            }

            try
            {
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    context.Contacts_feedback.Add(Contacts_feedback);
                    context.SaveChanges(); // установите точку останова здесь
                }

                ViewBag.Message = "Сообщение успешно отправлено!";
                return View("Success");
            }
            catch (Exception ex)
            {
                // Логируйте ошибку
                Console.WriteLine("Ошибка сохранения: " + ex.Message);
                return View("Error");
            }

        }

    }
}
