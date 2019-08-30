using ClassLibrary.model.Filters;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model
{
    public class RightAccess
    {
        public virtual int Id { get; set; }
        [FastSearch]
        public virtual int MyRightAccess { get; set; }
        public virtual IList<Group> GroupList { get; set; }
        public virtual IList<Person> Person { get; set; }
        public virtual IList<Folder> Folder { get; set; }

    }
    public class RightAccessMap : ClassMap<RightAccess>
    {
        public RightAccessMap()
        {

            Id(x => x.Id).GeneratedBy.HiLo("100");
            Map(x => x.MyRightAccess);
            HasMany(x => x.Person).Inverse();
            HasMany(x => x.GroupList).Inverse();
            HasMany(x => x.Folder).Inverse();
        }
    }
}
