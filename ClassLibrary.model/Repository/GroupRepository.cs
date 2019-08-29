using ClassLibrary.model.Filters;
using NHibernate;
using NHibernate.Criterion;
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
        public IList<Group> LoadAll()
        {
            var criteria =
             session.CreateCriteria<Group>()
                 .Add(Restrictions.Ge("Id", 1));

            var group = criteria.List<Group>();
            return group;
        }

    }
}
