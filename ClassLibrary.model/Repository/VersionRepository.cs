using ClassLibrary.model.Filters;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model.Repository
{
    [Repository]
    public class VersionRepository : Repository<Version, VersionFilter>

    {
        public VersionRepository(ISession session)
            : base(session)
        {
        }

    }
   
}
