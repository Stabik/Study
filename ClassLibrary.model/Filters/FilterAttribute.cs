using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model.Filters
{
    public class FilterAttribute : Attribute
    {
        public Type Type { get; set; }
    }
}
