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
       
        public DocumentController(DocumentReposirory documentRepository)
        {
            this.documentRepository = documentRepository;
           
            
        }

        //        // GET: Document
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Create()
        {
            var docModel = new DocumentModel();            
            return View(docModel);
        }
        [HttpPost]
        public ActionResult Create(DocumentModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            Document docParent = null;
            if (model.ParentId.HasValue)
            {
                docParent = documentRepository.Load(model.ParentId.Value);
            }
            var doc = new Document
            {
                Name = model.Name,
                CreationDate= DateTime.Now,
               Parent= docParent,
                Avatar = model.Avatar != null && model.Avatar.InputStream != null ?
                        model.Avatar.InputStream.ToByteArray() :
                        null

            };

            documentRepository.Save(doc);
            return RedirectToAction("Index", "Folder", new { parent = model.ParentId });

        }
       
    }
}