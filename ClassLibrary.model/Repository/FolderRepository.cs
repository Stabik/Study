using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model.Repository
{
    [Repository]
    public class FolderRepository : Repository<Folder>

    {
        public FolderRepository(ISession session)
            : base(session)
        {
        }

    }
   
}
