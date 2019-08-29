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
    public class FolderController : Controller
    {
        private FolderRepository folderRepository;
        private DocumentReposirory documentRepository;

        public FolderController(FolderRepository folderRepository, DocumentReposirory documentRepository)
        {
            this.folderRepository = folderRepository;
            this.documentRepository = documentRepository;
        }

        public ActionResult Create(long? parent)
        {
            var model = new FolderEditModel
            {
                ParentId = parent
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(FolderEditModel model)
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
            var folder = new Folder
            {
                Name = model.Name,
                CreationDate = DateTime.Now,
                Parent = parent
            };
            folderRepository.Save(folder);
            return RedirectToAction("Index", new { parent = model.ParentId });
        }

        public ActionResult Index(long? parent, FetchOptions fetchOptions)
        {
            Folder parentFolder = null;
            if (parent.HasValue)
            {
                parentFolder = folderRepository.Load(parent.Value);
            }
            var model = new FolderModel
            {
                Items = folderRepository.Find(new FolderFilter { Parent = parentFolder }, fetchOptions),
                CurrentFolder = parentFolder,
                Parent = parentFolder != null ? parentFolder.Parent : null
            };
            model.IsRootFolder = parent == null && model.Parent == null;
            return View("List", model);
        }
        public ActionResult GetAvatar(long id)
        {
            var user = documentRepository.Load(id);
            return File(user.Avatar, "application/octet-stream", $"{user.Name}.jpeg");
        }
    }
}