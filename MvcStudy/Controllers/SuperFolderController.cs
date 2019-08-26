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
    public class SuperFolderController : Controller
    {    // GET: Group
        public ActionResult Index()
        {
            return View();
        }
        private SuperFolderRepository superFolderRepository;

        public SuperFolderController(SuperFolderRepository superFolderRepository)
        {
            this.superFolderRepository = superFolderRepository;
        }

        public ActionResult LoadAllSuperFolder()
        {
            var models = superFolderRepository.LoadAll();
            return View(models);
        }

        public ActionResult Create()
        {
            var model = new SuperFolderModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(SuperFolderModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var superFolder = new SuperFolder
            {
                SuperFolderName = model.Name
            };

            superFolderRepository.Save(superFolder);

            return RedirectToAction("Index", "Home");
        }
    }
}