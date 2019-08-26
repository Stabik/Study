using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;

namespace ClassLibrary.model.Repository
{
    [Repository]
    public class SuperFolderRepository : Repository<SuperFolder>

    {
        public SuperFolderRepository(ISession session) : base(session)
        {
        }
    }
}
