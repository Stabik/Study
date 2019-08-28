using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model.Filters
{

    public struct Range<T>
        where T : struct
    {
        public T? From { get; set; }

        public T? To { get; set; }
    }
}
