using ClassLibrary.model.Filters;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model
{
   public class Folder
    {
        public virtual long Id { get; set; }

        [FastSearch]
        public virtual string Name { get; set; }
        public virtual Folder Parent { get; set; }
        [FastSearch]
        public virtual IList<Version> Version { get; set; }
        public virtual DateTime CreationDate { get; set; }
        public virtual RightAccess MyRightAccess { get; set; }
        
    }
    public class FolderMap : ClassMap<Folder>
    {
        public FolderMap()
        {
            Id(x => x.Id).GeneratedBy.HiLo("100");
            Map(x => x.Name).Length(50);
            Map(f => f.CreationDate);
            References(f => f.Parent).Cascade.SaveUpdate();
            HasMany(x => x.Version).Inverse();
            References(x => x.MyRightAccess).Cascade.SaveUpdate();
           

        }
    }
}
