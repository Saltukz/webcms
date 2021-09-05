using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace business.Abstract
{
    public interface IUygulamalarService
    {
        Uygulama GetBySeoUrl(string seourl);

        List<Uygulama> GetAllByCulture(string culture);
        Uygulama GetById(int id);

        List<Uygulama> GetAll();

        void Create(Uygulama entity);

        void Update(Uygulama entity);

        void Delete(Uygulama entity);
        List<Uygulama> GetByPageSize(int page, int pageSize);
        List<Tuple<string, string>> GetTuple();
    
    }
}
