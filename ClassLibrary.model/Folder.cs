using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model
{
   public class Folder
    {
        public virtual int Id { get; set; }
        public virtual string NameFolder { get; set; }
        public virtual string FolderType { get; set; }
        public virtual IList<Version> Version { get; set; }
        public virtual RightAccess MyRightAccess { get; set; }
        public virtual SuperFolder superFolder { get; set; }
    }
    public class FolderMap : ClassMap<Folder>
    {
        public FolderMap()
        {
            Id(x => x.Id).GeneratedBy.HiLo("100");
            Map(x => x.NameFolder).Length(50);
            Map(x => x.FolderType);
            HasMany(x => x.Version).Inverse();
            References(x => x.MyRightAccess).Cascade.SaveUpdate();
            References(x => x.superFolder).Cascade.SaveUpdate();

        }
    }
}
