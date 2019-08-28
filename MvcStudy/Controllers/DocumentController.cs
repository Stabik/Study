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
    //public class DocumentController : Controller
    //{
    //    private DocumentReposirory documentRepository;
    //    private SuperFolderRepository superFolderRepository;
    //    private FolderRepository folderRepository;
    //    public DocumentController(DocumentReposirory documentRepository, SuperFolderRepository superFolderRepository, FolderRepository folderRepository)
    //    {
    //        this.documentRepository = documentRepository;           
    //        this.superFolderRepository=superFolderRepository;
    //        this.folderRepository = folderRepository;
    //}
    //    public ActionResult LoadAllDocument()
    //    {
    //        var models = documentRepository.LoadAll();
    //        return View(models);
    //    }
    //    public ActionResult LoadAllDocumnetById(int id)
    //    {
    //        var models = documentRepository.LoadAll(id);
    //        return View(models);
           
    //    }
    //    public ActionResult LoadAllDocumnetByIdSuperFolder(int id)
    //    {
    //        var models = superFolderRepository.Load(id);/////////////////////////////
    //        var models2 = documentRepository.LoadAll(models.Id);
    //        return View(models2);

    //    }
    //        public ActionResult LoadDocument(int id)
    //    {
    //        var models = documentRepository.LoadAll(id);
    //        return View(models);
    //    }
    //        // GET: Document
    //        public ActionResult Index()
    //    {
           
    //        return View();
    //    }
    //    public ActionResult Create()
    //    {
    //        var docModel = new DocumentModel();
    //        var models = superFolderRepository.LoadAll();
    //        SelectList groups = new SelectList(models, "Id", "SuperFolderName");
    //        ViewBag.Groups = groups;

    //        return View(docModel);
    //    }
    //    [HttpPost]
    //    public ActionResult Create(DocumentModel model)/*, HttpPostedFileBase file1)*/
    //    {
    //        SuperFolder SuperFolder = new SuperFolder();
    //        SuperFolder = superFolderRepository.Load(model.SuperFolderModel.Id);
           
    //        var doc = new Document
    //        {
    //            NameFolder = model.NameFolder,
    //            superFolder= SuperFolder
    //        };

    //        documentRepository.Save(doc);



    //        return RedirectToAction("Index", "Home");

    //    }
    //}
}