﻿using ClassLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcStudy.Models
{
    public class DocumentModel:FolderModel
    {
        public  DateTime DateTime { get; set; }
       
        public  Person Author { get; set; }
        public HttpPostedFileWrapper Avatar { get; set; }
        public long? ParentId { get; set; }
        
       
    }
}