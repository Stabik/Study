using ClassLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcStudy.Models
{
    public class ReportModel:EntityListModel<ReportClass>
    {
        public long? AllFolders { get; set; }
        public long? AllDocuments { get; set; }
        public long? AllFilesAdded { get; set; }

    }
}