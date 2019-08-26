using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MvcStudy.Models
{
    public class GroupModel
    {
        [DisplayName("Название группы")]
        public string NameGroup { get; set; }
        public int Id { get; set; }
       
        public PersonModel personModels { get; set; }
    }
}