using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model.Filters
{
    public class FetchOptions
    {
        public string SortExpression { get; set; }

        public SortDirection SortDirection { get; set; }

        public int? First { get; set; }

        public int? Count { get; set; }
    }

    public enum SortDirection
    {
        Asc,
        Desc
    }
}
