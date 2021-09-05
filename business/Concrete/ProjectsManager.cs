using business.Abstract;
using data.Abstract;
using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace business.Concrete
{
    public class ProjectsManager : IProjectsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjectsManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(Projects entity)
        {
            _unitOfWork.Projects.Create(entity);
            _unitOfWork.Save();
        }

        public void Delete(Projects entity)
        {
            _unitOfWork.Projects.Delete(entity);
            _unitOfWork.Save();
        }

        public List<Projects> GetAll()
        {
            return _unitOfWork.Projects.GetAll();
        }

        public Projects GetByCode(string pcode)
        {
            return _unitOfWork.Projects.GetByCode(pcode);
        }

        public Projects GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Projects entity)
        {
            throw new NotImplementedException();
        }
    }
}
