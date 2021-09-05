using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace entity
{
    public class Dokuman
    {
        [Key]
        public int DokumanId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Culture { get; set; }

        public string DokumanUrl { get; set; }






        public List<DokumanMnMRel> DokumanMnMRels { get; set; }
    }
}
