using business.Abstract;
using data.Abstract;
using entity;
using System;
using System.Collections.Generic;
using System.Text;

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

        public List<ProjectGalery> GetAll()
        {
            return _unitOfWork.ProjectGaleries.GetAll();
        }

        public ProjectGalery GetById(int id)
        {
            throw new NotImplementedException();
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
