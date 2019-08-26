using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model.Repository
{
    [Repository]
    public class VersionRepository : Repository<Version>

    {
        public VersionRepository(ISession session)
            : base(session)
        {
        }

    }
   
}
