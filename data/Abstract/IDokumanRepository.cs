using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace data.Abstract
{
    public interface IDokumanRepository : IRepository<Dokuman>
    {
        List<Dokuman> GetAllWithCategories();
        List<Dokuman> GetByPageSize(int page, int pageSize);
        void CreateRaw(Dokuman entity, int[] dokumanCategoryIds);
        List<Tuple<int, List<int>>> GetRelationTable();
        List<Tuple<string, string>> GetTuple();
        List<Dokuman> GetSearchResult(string searchString);
    }
}
