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
        public List<Folder> GetAllFoldersByDate(DateTime? startDate,DateTime? endDate)
        {
            var crit = session.QueryOver<Folder>().Where(x => x.CreationDate > startDate && x.CreationDate < endDate);
            List<Folder> FolderList = new List<Folder>();
            foreach(var i in crit.List<Folder>())
            {
                FolderList.Add(i);
            }
            return FolderList;
           
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
            if (!string.IsNullOrEmpty(filter.Name))
            {
                crit.Add(Restrictions.Eq("Name", filter.Name));
            }    
            if (filter.CreationDate.From.HasValue)
            {
                crit.Add(Restrictions.Ge("CreationDate", filter.CreationDate.From.Value));
            }
            if (filter.CreationDate.To.HasValue)
            {
                crit.Add(Restrictions.Le("CreationDate", filter.CreationDate.To.Value));
            }

        
    }
     
    }

}
