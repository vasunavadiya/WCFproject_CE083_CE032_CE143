using socmvc.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace socmvc.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult getPersons()
        {
            Service1Client o = new Service1Client();
            List<Person> li = o.GetPersons().ToList();
            ViewBag.List = li;
            return View();
        }
        public ActionResult insertPerson()
        {
            return View();
        }
        [HttpPost]
        public ActionResult insertPerson(Person obj)
        {

            Service1Client o = new Service1Client();
            o.InsertPerson(obj);
            return View();
        }
        public ActionResult updatePerson()
        {
            return View();
        }
        [HttpPost]
        public ActionResult updatePerson(Person obj)
        {
            Service1Client o = new Service1Client();
                o.UpdatePerson(obj);
            return View();
        }
        public ActionResult deletePerson()
        {
            return View();
        }
        [HttpPost]
        public ActionResult deletePerson(int id)
        {
            Service1Client o = new Service1Client();
            o.DeletePerson(id);
            return View();
        }

    }

}