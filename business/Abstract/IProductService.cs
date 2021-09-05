using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);

        List<Product> GetAll();

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
