using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model.Repository
{
    [Repository]
    public class PersonRepository : Repository<Person>
    {
        public PersonRepository(ISession session)
            : base(session)
        {
        }
        //public IList<Person> LoadPerson()
        //{
        //    var criteria =
        //     session.CreateCriteria<Person>()
        //         .Add(Restrictions.Ge("Id", 1));
                
        //    var people = criteria.List<Person>();
        //    return people;
        //}

    }
}
