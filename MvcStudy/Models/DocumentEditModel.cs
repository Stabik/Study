using ClassLibrary.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcStudy.Models
{
    public class DocumentEditModel: FolderEditModel
    {
    
        public HttpPostedFileWrapper Avatar { get; set; }
    }
}