using System;
using System.Collections.Generic;
using System.Text;

namespace entity
{
    public class ProjectGaleryRelation
    {
        public int ProjectId { get; set; }

        public Projects Projects { get; set; }

        public int ProjectGalleryId { get; set; }

        public ProjectGalery ProjectGalery { get; set; }
    }
}
