using ClassLibrary.model;
using ClassLibrary.model.Repository;
using MvcStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcStudy.Controllers
{
    public class PersonController : Controller
    {
        private PersonRepository personRepository;
        private GroupRepository groupRepository;

        public PersonController(PersonRepository personRepository, GroupRepository groupRepository)
        {
            this.personRepository = personRepository;
            this.groupRepository=groupRepository;
    }

        public ActionResult Create()
        {
            var model = new PersonModel();
            var models = groupRepository.LoadAll();
            SelectList groups = new SelectList(models, "Id", "NameGroup");
            ViewBag.Groups = groups;
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(PersonModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            Group group = new Group();
            group = groupRepository.Load(model.group.Id);
            var person = new Person
            {
                Login = model.Login,
                Password = model.Password,
                Group = group

            };


            personRepository.Save(person);



            return RedirectToAction("Index", "Home");
        }

        
    }
}
