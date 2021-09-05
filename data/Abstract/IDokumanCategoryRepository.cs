using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace data.Abstract
{
    public interface IDokumanCategoryRepository : IRepository<DokumanCategory>
    {
        List<DokumanCategory> GetByPageSize(int page, int pageSize);
        List<Tuple<string, string>> GetTuple();
        void DeleteWithDocuments(DokumanCategory entity);
      
    }
}
