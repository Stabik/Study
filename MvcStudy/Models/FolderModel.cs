using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcStudy.Models
{
    public class FolderModel
    {
        public  string NameFolder { get; set; }
       public int Id { get; set; }
        public  Version Version { get; set; }
        public SuperFolderModel SuperFolderModel { get; set; }
    }
}