using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model.Filters
{
    public abstract class BaseFilter
    {
        public long? Id { get; set; }

        public string SearchString { get; set; }
    }
}
