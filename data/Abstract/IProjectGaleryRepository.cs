using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace data.Abstract
{
    public interface IProjectGaleryRepository : IRepository<ProjectGalery>
    {
        List<ProjectGalery> GetGalleryByProject(string pcode, string culture);
    }
}
