using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace entity
{
    public class Projects
    {

        [Key]
        public int ProjectId { get; set; }

        public string Code { get; set; }

        public string Culture { get; set; }

        public string Name { get; set; }

        public string MetaDescription { get; set; }

      

      

        public List<ProjectGaleryRelation> ProjectGaleryRelations { get; set; }



    }
}
