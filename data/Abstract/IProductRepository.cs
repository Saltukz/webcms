using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace data.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        Product GetByCodeandCulture(int code,string culture);

        List<Product> GetProductsbyCategory(string url);
        List<Product> GetByPageSize(int page, int pageSize);
        List<Tuple<int, List<int>>> GetRelationTable();
        void CreateRaw(Product entity, int[] thermoformCategoryIds);
        Product GetByIdWithCategories(int id);
        void Update(Product entity, int[] thermoformCategoryIds);
        void DeleteWithRelation(Product entity);
    }
}
