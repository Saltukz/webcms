using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace business.Abstract
{
    public interface IDokumanCategoryService
    {
        DokumanCategory GetById(int id);

        List<DokumanCategory> GetAll();

        void Create(DokumanCategory entity);

        void Update(DokumanCategory entity);

        void Delete(DokumanCategory entity);
        List<DokumanCategory> GetByPageSize(int page, int pageSize);
        List<Tuple<string, string>> GetTuple();
        void DeleteWithDocuments(DokumanCategory entity);
    
    }
}
