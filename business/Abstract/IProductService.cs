using entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace business.Abstract
{
    public interface IProductService
    {
        Task<Product> GetById(int id);

        Task<List<Product>> GetAll();

        Task<Product> CreateAsync(Product entity);

        void Create(Product entity);


        void Update(Product entity);

        void Delete(Product entity);

        Product GetByCodeandCulture(int code, string culture);


        List<Product> GetProductsbyCategory(string url);
        List<Product> GetByPageSize(int page, int pageSize);
        List<Tuple<int, List<int>>> GetRelationTable();
        void CreateRaw(Product entity, int[] thermoformCategoryIds);
        Product GetByIdWithCategories(int id);
        void Update(Product entity, int[] thermoformCategoryIds);
        void DeleteWithRelation(Product entity);
    }
}
