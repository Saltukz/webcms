using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace entity
{
    public class ProjectGalery
    {

        [Key]
        public int ProjectGalleryId { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string ImageUrl { get; set; }

        public string Culture { get; set; }

        public string ProjeAlani { get; set; }

        public string YapimYili { get; set; }

        public string AlanOlcumu { get; set; }

        public string UrunAdi { get; set; }

        public string AlanUrl { get; set; }

        public List<ProjectGaleryRelation> ProjectGaleryRelations  { get; set; }
    }
}