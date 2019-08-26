using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MvcStudy.Models
{
    public class SuperFolderModel
    {
        [DisplayName("Название группы")]
        public string Name { get; set; }
        public int Id { get; set; }
        public FolderModel FolderModel { get; set; }
    }
}