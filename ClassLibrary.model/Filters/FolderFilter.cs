﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model.Filters
{
    public class FolderFilter : BaseFilter
    {
        public string Name { get; set; }
        public Folder Parent { get; set; }
        public Range<DateTime> CreationDate { get; set; }
        public Person CreationAuthor { get; set; }
    }
}
