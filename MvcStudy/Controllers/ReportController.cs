using ClassLibrary.model;
using ClassLibrary.model.Filters;
using ClassLibrary.model.Repository;
using MvcStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcStudy.Controllers
{
    public class ReportController : Controller
    {
        private FolderRepository folderRepository;
       
        public ReportController(FolderRepository folderRepository)
        {
            this.folderRepository = folderRepository;
           
        }
        public ActionResult Index()
        {
          
            return View();
        }

       [HttpPost]
        public ActionResult Index(DateTime? startDate, DateTime? endDate) 

        {
           
            var folderList = folderRepository.GetAllFoldersByDate(startDate, endDate);
                List<Document> docList = new List<Document>();
                foreach (var fold in folderList)
                {
                    if (fold is Document)
                    {
                        docList.Add((Document)fold);
                    }

                }
                var reportModel = new ReportModel
                {
                    AllDocuments = docList.Count,
                    AllFilesAdded = folderList.Count,
                    AllFolders = folderList.Count - docList.Count
                };
            return View(reportModel);


        }
    }
}