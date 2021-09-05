using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace business.Abstract
{
    public interface IDokumanService
    {
        Dokuman GetById(int id);

        List<Dokuman> GetAll();

        void Create(Dokuman entity);

        void Update(Dokuman entity);

        void Delete(Dokuman entity);
        List<Dokuman> GetAllWithCategories();
        List<Dokuman> GetByPageSize(int page, int pageSize);
        void CreateRaw(Dokuman entity, int[] dokumanCategoryIds);
        List<Tuple<int, List<int>>> GetRelationTable();
        List<Tuple<string, string>> GetTuple();
        List<Dokuman> GetSearchResult(string searchString);
    }
}
