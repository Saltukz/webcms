using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace data.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {

        Category GetBySeoUrl(string seourl);

        List<Category> GetAllByCulture(string culture);
        List<Category> GetByPageSize(int page, int pageSize);
        void DeleteWithDocuments(Category entity);

        List<Category> GetSearchResult(string searchString);
        List<Tuple<string, string>> GetTuple();
    }
}
