using ClassLibrary.model;
using ClassLibrary.model.Filters;
using ClassLibrary.model.Repository;
using MvcStudy.Files;
using MvcStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcStudy.Controllers
{
   public class DocumentController : Controller
    {
        private DocumentReposirory documentRepository;
        private FolderRepository folderRepository;

        public DocumentController(DocumentReposirory documentRepository, FolderRepository folderRepository)
        {
            this.documentRepository = documentRepository;
            this.folderRepository = folderRepository;


        }

        //        // GET: Document
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Create(long? parent)
        {
            var docModel = new DocumentEditModel
            {
                ParentId = parent
            };
            return View(docModel);
        }
        [HttpPost]
        public ActionResult Create(DocumentEditModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            Folder parent = null;
            if (model.ParentId.HasValue)
            {
                parent = folderRepository.Load(model.ParentId.Value);
            }
            var doc = new Document
            {
                Name = model.Name,
                CreationDate= DateTime.Now,
               Parent= parent,
                Avatar = model.Avatar != null && model.Avatar.InputStream != null ?
                        model.Avatar.InputStream.ToByteArray() :
                        null

            };

            documentRepository.Save(doc);
            return RedirectToAction("Index", "Folder", new { parent = model.ParentId });

        }
       
    }
}