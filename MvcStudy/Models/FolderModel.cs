using ClassLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcStudy.Models
{
    public class FolderModel : EntityListModel<Folder>
    {
        public Folder Parent { get; set; }

        public Folder CurrentFolder { get; set; }
       

        public bool IsRootFolder { get; set; }
        public string Name { get; set; }

    }
}