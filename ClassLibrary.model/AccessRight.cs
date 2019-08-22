using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model
{
    public class AccessRight
    {
        
       public virtual IList<Group> GroupList { get;set;}
        
        public virtual IList<Person> Person { get; set; }
        
        public virtual IList<Folder > Folder {get;set;}
        public virtual int Right { get; set; }

    }
    public class AccessRightMap: ClassMap<AccessRight>
    {
        public AccessRightMap()
        {
            Map(x => x.Right);
            HasMany(x => x.Person).Inverse();
            HasMany(x => x.GroupList).Inverse();
            HasMany(x => x.Folder).Inverse();
        }
    }
}
