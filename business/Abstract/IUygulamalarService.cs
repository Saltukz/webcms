using entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace business.Abstract
{
    public interface IUygulamalarService
    {
        Uygulama GetBySeoUrl(string seourl);

        List<Uygulama> GetAllByCulture(string culture);
        Task<Uygulama> GetById(int id);

        Task<List<Uygulama>> GetAll();

        void Create(Uygulama entity);

        void Update(Uygulama entity);

        void Delete(Uygulama entity);
        List<Uygulama> GetByPageSize(int page, int pageSize);
        List<Tuple<string, string>> GetTuple();
    
    }
}
