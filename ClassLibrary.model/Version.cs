using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.model
{
   public class Version
    {
        public virtual int Id { get; set; }
       
       public virtual long Number { get; set; }
        public virtual DateTime DateTime { get; set; }
        public virtual Folder Folder { get; set; }
        
    }
    public class VersionMap:ClassMap<Version>
    {
        public VersionMap()
        {
            Id(x => x.Id).GeneratedBy.HiLo("100");
            Map(x => x.Number);
            Map(x => x.DateTime);
            References(x => x.Folder).Cascade.SaveUpdate();
           


        }
    }

}
