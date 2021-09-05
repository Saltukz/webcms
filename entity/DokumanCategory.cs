using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace entity
{
    public class DokumanCategory
    {

        [Key]
        public int DokumanCategoryId { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string Culture { get; set; }

        public List<DokumanMnMRel> DokumanMnMRels { get; set; }


    }
}
