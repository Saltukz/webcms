using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace business.Abstract
{
    public interface IProjectGaleryService
    {
        ProjectGalery GetById(int id);

        List<ProjectGalery> GetAll();

        void Create(ProjectGalery entity);

        void Update(ProjectGalery entity);

        void Delete(ProjectGalery entity);
        List<ProjectGalery> GetGalleryByProject(string pcode, string culture);
    }
}
