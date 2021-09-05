using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace business.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);

        List<Category> GetAll();

        void Create(Category entity);

        void Update(Category entity);

        void Delete(Category entity);

        Category GetBySeoUrl(string seourl);

        List<Category> GetAllByCulture(string culture);
        List<Category> GetByPageSize(int page, int pageSize);
        void DeleteWithDocuments(Category entity);
        List<Category> GetSearchResult(string searchString);
        List<Tuple<string, string>> GetTuple();
    }
}
