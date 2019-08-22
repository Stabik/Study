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
        public virtual Version Version { get; set; }
        public virtual AccessRight Right { get; set; }
    }
    public class FolderMap: ClassMap<Folder>
    {
        public FolderMap()
        {
            Id(x => x.Id).GeneratedBy.HiLo("100");
            Map(x => x.NameFolder).Length(50);            
            HasOne(x => x.Version).Cascade.All().Constrained();
            References(x => x.Right).Cascade.SaveUpdate();

        }
    }
}
