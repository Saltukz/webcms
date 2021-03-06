using entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace business.Abstract
{
    public interface INewsService
    {
        Task<News> GetById(int id);

        Task<List<News>> GetAll();

        void Create(News entity);

        void Update(News entity);

        void Delete(News entity);
        News GetBySeoUrl(string seocode,string culture);
        List<News> GetByPageSize(int page, int pageSize);
        List<Tuple<string,string>> GetTuple();
    }
}
