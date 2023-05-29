using Microsoft.AspNetCore.Mvc;
using WebApp2.Services;
using WebApp2.ViewModels;

namespace WebApp2.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactService _contact;

        public ContactController(ContactService contact)
        {
            _contact = contact;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactFormViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                _contact.SaveContact(viewModel);
                return RedirectToAction("Index", "Home");
            }

            return View(viewModel);
        }
    }
}
