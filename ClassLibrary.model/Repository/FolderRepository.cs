using ClassLibrary.model.Filters;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model.Repository
{
    [Repository]
    public class FolderRepository : Repository<Folder, FolderFilter>
    {
        public FolderRepository(ISession session) : base(session)
        {
        }

        protected override void SetupFilter(ICriteria crit, FolderFilter filter)
        {
            base.SetupFilter(crit, filter);
            if (filter.Parent != null)
            {
                crit.Add(Restrictions.Eq("Parent", filter.Parent));
            }
            else
            {
                crit.Add(Restrictions.IsNull("Parent"));
            }
        }
    }

}
