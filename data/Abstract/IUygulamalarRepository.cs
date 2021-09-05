using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace data.Abstract
{
    public interface IUygulamalarRepository:IRepository<Uygulama>
    {
        Uygulama GetBySeoUrl(string seourl);

        List<Uygulama> GetAllByCulture(string culture);
        List<Uygulama> GetByPageSize(int page, int pageSize);
        List<Tuple<string, string>> GetTuple();
     
    }
}
