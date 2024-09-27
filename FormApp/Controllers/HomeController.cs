using FormApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Submissions()
        {
            List<Person> persons = DataRepository.GetPersons();
            return View(persons);
        }

        [HttpPost]
        public IActionResult Submissions(Person person)
        {

            if (!ModelState.IsValid) 
            {
                return View("Index", person);            
            }

            DataRepository.addPerson(person);
            return RedirectToAction("Submissions");
        
        }

        [HttpPost]
        public IActionResult ClearData() 
        {
            DataRepository.RemoveAll();
            return RedirectToAction("Submissions");
        }
    }
}
