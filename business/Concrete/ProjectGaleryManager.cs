using business.Abstract;
using data.Abstract;
using entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace business.Concrete
{
    public class ProjectGaleryManager : IProjectGaleryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjectGaleryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(ProjectGalery entity)
        {
            _unitOfWork.ProjectGaleries.Create(entity);
            _unitOfWork.Save();
        }

        public void Delete(ProjectGalery entity)
        {
            _unitOfWork.ProjectGaleries.Delete(entity);
            _unitOfWork.Save();
        }

        public async Task<List<ProjectGalery>> GetAll()
        {
            return await _unitOfWork.ProjectGaleries.GetAll();
        }

        public async Task<ProjectGalery> GetById(int id)
        {
            return await _unitOfWork.ProjectGaleries.GetById(id);
        }

        public List<ProjectGalery> GetGalleryByProject(string pcode, string culture)
        {
            return _unitOfWork.ProjectGaleries.GetGalleryByProject(pcode, culture);
        }

        public void Update(ProjectGalery entity)
        {
            throw new NotImplementedException();
        }
    }
}
