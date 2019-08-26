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
    public class GroupController : Controller
    {
        // GET: Group
        public ActionResult Index()
        {
            return View();
        }
        private GroupRepository groupRepository;

        public GroupController(GroupRepository groupRepository)
        {
            this.groupRepository = groupRepository;
        }

        public ActionResult Create()
        {
            var model = new GroupModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(GroupModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
          
            var group = new Group
            {
               NameGroup=model.NameGroup
            };

            groupRepository.Save(group);

            return RedirectToAction("Index", "Home");
        }
       
    }
}