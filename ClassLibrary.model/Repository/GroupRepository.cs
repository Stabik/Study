using ClassLibrary.model.Filters;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model.Repository
{
    [Repository]
    public class GroupRepository: Repository<Group,GroupFilter>

    {
        public GroupRepository(ISession session)
            : base(session)
        {
        }
        
    }
}
