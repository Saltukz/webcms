using business.Abstract;
using data.Abstract;
using entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<List<Projects>> GetAll()
        {
            return await _unitOfWork.Projects.GetAll();
        }

        public Projects GetByCode(string pcode)
        {
            return _unitOfWork.Projects.GetByCode(pcode);
        }

        public async  Task<Projects> GetById(int id)
        {
            return await _unitOfWork.Projects.GetById(id);
        }

        public void Update(Projects entity)
        {
            throw new NotImplementedException();
        }
    }
}
