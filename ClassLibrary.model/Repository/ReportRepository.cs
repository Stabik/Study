using ClassLibrary.model.Filters;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model.Repository
{
    public class ReportRepository : Repository<ReportClass, ReportFilter>
    {
        public ReportRepository(ISession session)
            : base(session)
        {
        }


        
    }
 }
