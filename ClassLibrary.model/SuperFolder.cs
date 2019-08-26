using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model
{
    public class SuperFolder
    {
        public virtual int Id { get; set; }
        public virtual string SuperFolderName { get; set; }
        public virtual IList<Folder> Folder { get; set; }
        
    }
    public class SuperFolderMap : ClassMap<SuperFolder>
    {
        public SuperFolderMap()
        {
            Id(x => x.Id).GeneratedBy.HiLo("100");
            Map(x => x.SuperFolderName);
            HasMany(x => x.Folder).Inverse();
           
        }
    }

}
