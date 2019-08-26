using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model.Repository
{
    
        public class Repository<T>
         where T : class
        {
            protected ISession session;

            public Repository(ISession session)
            {
                this.session = session;
            }

            public virtual T Load(int id)
            {
                return session.Get<T>(id);
            }
        public virtual IList<T> LoadAll()
        {
            var criteria =
             session.CreateCriteria<T>()
                 .Add(Restrictions.Ge("Id", 1));

            var LoadAllEntity = criteria.List<T>();
            return LoadAllEntity;
        }
        public virtual IList<T> LoadAll(int id)
        {
            var criteria =
             session.CreateCriteria<T>()
                 .Add(Restrictions.Eq("Id",id));

            var LoadAllEntity = criteria.List<T>();
            return LoadAllEntity;
        }

        public virtual void Save(T entity)
            {
            using (var tran = session.BeginTransaction())
            {
                session.SaveOrUpdate(entity);
                tran.Commit();
            }
           
               
            }
        }
    
}
