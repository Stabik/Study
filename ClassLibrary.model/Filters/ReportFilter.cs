using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model.Filters
{
   public class ReportFilter:BaseFilter
    {
        public Range<DateTime> CreationDate { get; set; }
        public IList<Document> DocList { get; set; }
        public IList<Folder> FolderList { get; set; }
    }
}
