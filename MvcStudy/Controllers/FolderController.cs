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
    public class FolderController : Controller
    {
        private FolderRepository folderRepository;
        public FolderController(FolderRepository folderRepository)
        {
            this.folderRepository = folderRepository;
        }
        public ActionResult LoadAllFolder()
        {
            var models = folderRepository.LoadAll();
            return View(models);
        }
        // GET: Folder
        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult Create()
        {
            var folderModel = new FolderModel();

            return View(folderModel);
        }
        [HttpPost]
        public ActionResult Create(FolderModel model)
        {

            Folder Folder = new Folder
            {
               
                NameFolder = model.NameFolder
            };
           
            folderRepository.Save(Folder);


            return RedirectToAction("Index", "Home");


        }
    }
}