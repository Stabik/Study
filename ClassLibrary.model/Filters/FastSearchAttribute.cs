using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model.Filters
{
    public class FastSearchAttribute : Attribute
    {
        public FiledType FiledType { get; set; }
    }

    public enum FiledType
    {
        String,
        Int
    }
}
