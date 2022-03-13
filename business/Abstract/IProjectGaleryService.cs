using entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace business.Abstract
{
    public interface IProjectGaleryService
    {
        Task<ProjectGalery> GetById(int id);

        Task<List<ProjectGalery>> GetAll();

        void Create(ProjectGalery entity);

        void Update(ProjectGalery entity);

        void Delete(ProjectGalery entity);
        List<ProjectGalery> GetGalleryByProject(string pcode, string culture);
    }
}
