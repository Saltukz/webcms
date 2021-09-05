using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace data.Abstract
{
    public interface INewsRepository : IRepository<News>
    {
        News GetBySeoUrl(string seocode,string culture);
        List<News> GetByPageSize(int page, int pageSize);
        List<Tuple<string, string>> GetTuple();
    }
}
