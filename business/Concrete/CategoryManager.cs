using business.Abstract;
using data.Abstract;
using entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(Category entity)
        {
            _unitOfWork.Categories.Create(entity);
            _unitOfWork.Save();
        }

        public void Delete(Category entity)
        {
            _unitOfWork.Categories.Delete(entity);
            _unitOfWork.Save();
        }

        public void DeleteWithDocuments(Category entity)
        {
            _unitOfWork.Categories.DeleteWithDocuments(entity);
            _unitOfWork.Save();
        }

        public async Task<List<Category>> GetAll()
        {
            return await _unitOfWork.Categories.GetAll();
        }

        public List<Category> GetAllByCulture(string culture)
        {
            return _unitOfWork.Categories.GetAllByCulture(culture);
        }

        public async Task<Category> GetById(int id)
        {
            return await _unitOfWork.Categories.GetById(id);
        }

        public List<Category> GetByPageSize(int page, int pageSize)
        {
            return _unitOfWork.Categories.GetByPageSize(page, pageSize);
        }

        public Category GetBySeoUrl(string seourl)
        {
            return _unitOfWork.Categories.GetBySeoUrl(seourl);
        }

        public List<Category> GetSearchResult(string searchString)
        {
            return _unitOfWork.Categories.GetSearchResult(searchString);
        }

        public List<Tuple<string, string>> GetTuple()
        {
            return _unitOfWork.Categories.GetTuple();
        }

        public void Update(Category entity)
        {
            _unitOfWork.Categories.Update(entity);
            _unitOfWork.Save();
        }
    }
}
