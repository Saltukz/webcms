using business.Abstract;
using data.Abstract;
using data.Concrete.EfCore;
using entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(Product entity)
        {
            _unitOfWork.Products.Create(entity);
            _unitOfWork.Save();
        }

        public async Task<Product> CreateAsync(Product entity)
        {
            await _unitOfWork.Products.CreateAsync(entity);
            await _unitOfWork.SaveAsync();
            return entity;
        }

        public void CreateRaw(Product entity, int[] thermoformCategoryIds)
        {
            _unitOfWork.Products.CreateRaw(entity, thermoformCategoryIds);
            _unitOfWork.Save();
        }

        public void Delete(Product entity)
        {
            //işkuralları
            _unitOfWork.Products.Delete(entity);
            _unitOfWork.Save();
        }

        public void DeleteWithRelation(Product entity)
        {
            _unitOfWork.Products.DeleteWithRelation(entity);
            _unitOfWork.Save();
        }

        public async Task<List<Product>> GetAll()
        {
            return await _unitOfWork.Products.GetAll();
        }

        public Product GetByCodeandCulture(int code, string culture)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetById(int id)
        {
            return await _unitOfWork.Products.GetById(id);
        }

        public Product GetByIdWithCategories(int id)
        {
            return _unitOfWork.Products.GetByIdWithCategories(id);
        }

        public List<Product> GetByPageSize(int page, int pageSize)
        {
            return _unitOfWork.Products.GetByPageSize(page, pageSize);
        }

        public List<Product> GetProductsbyCategory(string url)
        {
            return _unitOfWork.Products.GetProductsbyCategory(url);
        }

        public List<Tuple<int, List<int>>> GetRelationTable()
        {
            return _unitOfWork.Products.GetRelationTable();
        }

        public void Update(Product entity)
        {
            _unitOfWork.Products.Update(entity);
            _unitOfWork.Save();
        }

        public void Update(Product entity, int[] thermoformCategoryIds)
        {
            _unitOfWork.Products.Update(entity, thermoformCategoryIds);
            _unitOfWork.Save();
        }
    }
}
