using business.Abstract;
using data.Abstract;
using entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace business.Concrete
{
    public class DokumanCategoryManager : IDokumanCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DokumanCategoryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

     

        public void Create(DokumanCategory entity)
        {
            _unitOfWork.DokumanCategories.Create(entity);
            _unitOfWork.Save();
        }

        public void Delete(DokumanCategory entity)
        {
            _unitOfWork.DokumanCategories.Delete(entity);
            _unitOfWork.Save();
        }

        public void DeleteWithDocuments(DokumanCategory entity)
        {
            _unitOfWork.DokumanCategories.DeleteWithDocuments(entity);
            _unitOfWork.Save();
        }

        public async Task<List<DokumanCategory>> GetAll()
        {
            return await _unitOfWork.DokumanCategories.GetAll();
        }

        

        public async Task<DokumanCategory> GetById(int id)
        {
            return await _unitOfWork.DokumanCategories.GetById(id);
        }

        public List<DokumanCategory> GetByPageSize(int page, int pageSize)
        {
            return _unitOfWork.DokumanCategories.GetByPageSize(page, pageSize);
        }

        public List<Tuple<string,string>> GetTuple()
        {
            return _unitOfWork.DokumanCategories.GetTuple();
        }

        public void Update(DokumanCategory entity)
        {
            _unitOfWork.DokumanCategories.Update(entity);
            _unitOfWork.Save();
        }
    }
}
